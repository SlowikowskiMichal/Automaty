using Lab8.Controller;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Threading;

namespace Lab8
{
    class GridController
    {
        public enum CellGrowthMode
        {
            Rectangle,
            Circle
        }

        #region Attributes

        NeighborhoodManager _Neighborhood;
        Bitmap CurrentBitmap;
        SolverEngine Solver;

        internal List<int> AliveRule;
        internal List<int> DeadRule;

        public List<Point> OriginGrains { get; internal set; }

        public NeighborhoodManager Neighborhood { get { return _Neighborhood; } private set { _Neighborhood = value; } }

        SolidBrush GridBrush = new SolidBrush(Color.LightGray);
        public Grid CurrentGrid;

        public int Iteration { get { return (int)SolverEngine.Iteration; } }

        
        public bool DrawGrid;
        public int Zoom;

        bool Running = false;

        #endregion

        #region Constructors

        static GridController _Instance;
        public decimal RectRotation;
        public decimal RectRatioSecond;
        public decimal RectRatioFirst;

        public static GridController GetInstance()
        {
            if(_Instance == null)
            {
                _Instance = new GridController(100, 100);
                _Instance._Neighborhood = NeighborhoodManager.GetInstance();
                _Instance.Solver = new FrontalSolverEngine();
            }
            return _Instance;
        }


        GridController(int sizeX, int sizeY, bool drawGrid = false, int zoom = 1)
        {
            RectRatioFirst = 1;
            RectRatioSecond = 1;

            //GRID
            CurrentGrid = new Grid(sizeX, sizeY);

            Zoom = zoom;
            DrawGrid = drawGrid;

            //RULES
            AliveRule = new List<int>();
            DeadRule = new List<int>();

            //GRID OPTIONS
            OriginGrains = new List<Point>();
        }

        #endregion

        #region Methods
        #region Private

        public void SetBoundaryCondition(int boundary)
        {
            _Neighborhood.Boundary = (BoundaryConditions)boundary;
        }

        internal void SetCellId(int x, int y, int currentNucleonId)
        {
            if(CurrentGrid.Cells[x,y].State != 0)
            {
                CurrentGrid.Cells[x, y].Id = currentNucleonId;
            }
            else
            {
                CurrentGrid.Cells[x, y].Id = 0;
            }
        }

        public void CalculateNextGrid(IProgress<Bitmap> progress, bool multipleSteps = true)
        {
            Running = true;
            //Stopwatch sw = new Stopwatch();
            List<Point> ChangedPoints = Solver.Setup();
            PrepareImage(ChangedPoints, CurrentBitmap);
            progress.Report(new Bitmap(CurrentBitmap));
            do
            {
                //sw.Reset();
                //sw.Start();
                ChangedPoints = Solver.Run(CurrentGrid);
                //sw.Stop();
                //Debug.WriteLine($"Calculations Time {sw.Elapsed}");
                //sw.Reset();
                //sw.Start();
                PrepareImage(ChangedPoints, CurrentBitmap);
                progress.Report(new Bitmap(CurrentBitmap));
                //sw.Stop();
                //Debug.WriteLine($"Report Time {sw.Elapsed}");
            } while (Running && multipleSteps && SolverEngine.Change);
            Running = false;
        }

        private void PrepareImage(List<Point> changedPoints, Bitmap b = null)
        {

            CurrentBitmap = b ?? new Bitmap(Grid.SizeX * Zoom, Grid.SizeY * Zoom, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            unsafe
            {
                BitmapData bitmapData = CurrentBitmap.LockBits(new Rectangle(0, 0, CurrentBitmap.Width, CurrentBitmap.Height),
                                      System.Drawing.Imaging.ImageLockMode.ReadWrite,
                                      CurrentBitmap.PixelFormat);
                int bytesPerPixel = System.Drawing.Bitmap.GetPixelFormatSize(CurrentBitmap.PixelFormat) / 8;
                int heightInPixels = bitmapData.Height;
                int widthInBytes = bitmapData.Width * bytesPerPixel;
                byte* ptrFirstPixel = (byte*)bitmapData.Scan0;
                int stride = bitmapData.Stride;

                Color c = Color.White;

                foreach (Point p in changedPoints)
                {
                    int x0 = p.X * Zoom * bytesPerPixel;
                    int y0 = p.Y * Zoom;
                    int x1 = x0 + (Zoom * bytesPerPixel);
                    int y1 = y0 + Zoom;

                    var state = CurrentGrid.Cells[p.X, p.Y].State;
                    if (state == 0)
                    {
                        c = Color.White;
                    }
                    else if (state == 1)
                    {
                        c = ColorTranslator.FromHtml(ColorManager.indexColors[CurrentGrid.Cells[p.X, p.Y].Id % ColorManager.indexColors.Length]);
                    }
                    else
                    {
                        c = Color.Black;
                    }


                    for (int y = y0; y < y1; y++)
                    {
                        byte* currentLine = ptrFirstPixel + (y * bitmapData.Stride);
                        for (int x = x0; x < x1; x = x + bytesPerPixel)
                        {
                            currentLine[x] = (byte)c.B;
                            currentLine[x + 1] = (byte)c.G;
                            currentLine[x + 2] = (byte)c.R;
                        }
                    }

                }

                CurrentBitmap.UnlockBits(bitmapData);
            }
        }

        internal void ZoomChanged()
        {
            CurrentBitmap = new Bitmap(Grid.SizeX * Zoom, Grid.SizeY * Zoom, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
        }

        private Bitmap PrepareImage()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            PrepareImage(CurrentGrid.CellsAsListOfPoints(), CurrentBitmap);
            sw.Stop();
            Debug.WriteLine($"Drawing Time {sw.Elapsed}");
            return new Bitmap(CurrentBitmap);
        }

        internal void SetCellAsActive(int x, int y, int currentNucleonId)
        {
            
            CurrentGrid.Cells[x, y].ChangeState(1);
            CurrentGrid.Cells[x, y].Id = currentNucleonId;
            CurrentGrid.Cells[x, y].SetAsCircleOrigin();
            CurrentGrid.Cells[x, y].Time = 0;
        }

        internal int AddRectangleCells(int numberOfActiveCells, double rotation, double firstRatio, double secondRatio)
        {
            List<Point> emptyCellPoints = new List<Point>();
            emptyCellPoints = GetEmptyCells();
            Random r = new Random();
            emptyCellPoints = emptyCellPoints.OrderBy(e => r.Next()).Take(numberOfActiveCells).ToList();

            foreach (Point p in emptyCellPoints)
            {
                SetCellAsActive(p.X, p.Y, OriginGrains.Count);
                CurrentGrid.Cells[p.X, p.Y].SetAsRectangleOrigin(rotation, firstRatio, secondRatio);
                OriginGrains.Add(CurrentGrid.Cells[p.X, p.Y].CurrentPosition);
                FrontalSolverEngine.FrontPoints.Add(p);
            }

            return emptyCellPoints.Count;
        }

        internal int AddRandomRectangleCells(int numberOfActiveCells)
        {
            List<Point> emptyCellPoints = new List<Point>();
            emptyCellPoints = GetEmptyCells();
            Random r = new Random();
            emptyCellPoints = emptyCellPoints.OrderBy(e => r.Next()).Take(numberOfActiveCells).ToList();


            foreach (Point p in emptyCellPoints)
            {
                var Rotation = r.NextDouble() * 90.0;
                var FirstRatio = r.NextDouble() * 10;
                var SecondRatio = r.NextDouble() * 10;
                SetCellAsActive(p.X, p.Y, OriginGrains.Count);
                CurrentGrid.Cells[p.X, p.Y].SetAsRectangleOrigin(Rotation, FirstRatio, SecondRatio);
                OriginGrains.Add(CurrentGrid.Cells[p.X, p.Y].CurrentPosition);
                FrontalSolverEngine.FrontPoints.Add(p);
            }

            return emptyCellPoints.Count;
        }

        internal int AddCircleCells(int numberOfActiveCells)
        {
            List<Point> emptyCellPoints = new List<Point>();
            emptyCellPoints = GetEmptyCells();
            Random r = new Random();
            emptyCellPoints = emptyCellPoints.OrderBy(e => r.Next()).Take(numberOfActiveCells).ToList();


            foreach (Point p in emptyCellPoints)
            {
                SetCellAsActive(p.X, p.Y, OriginGrains.Count);
                CurrentGrid.Cells[p.X, p.Y].SetAsCircleOrigin();
                OriginGrains.Add(CurrentGrid.Cells[p.X, p.Y].CurrentPosition);
                FrontalSolverEngine.FrontPoints.Add(p);
            }

            return emptyCellPoints.Count;
        }

        private List<Point> GetEmptyCells()
        {
            List<Point> emptyCells = new List<Point>();
            for(int x = 0; x < Grid.SizeX; x++)
            {
                for (int y = 0; y < Grid.SizeY; y++)
                {
                    if(CurrentGrid.Cells[x,y].State == 0)
                    {
                        emptyCells.Add(CurrentGrid.Cells[x, y].CurrentPosition);
                    }
                }
            }
            return emptyCells;
        }

        internal void ResetCell(int x, int y)
        {
            CurrentGrid.Cells[x, y].Reset();
            OriginGrains.Remove(CurrentGrid.Cells[x,y].CurrentPosition);
        }
//
//        void DrawGridWithBorder(int x, int y)
//        {
//            panelGraphics.
//                FillRectangle(b,
//                x * Zoom + 1, y * Zoom + 1,
//                Zoom - 2, Zoom - 2);
//
//        }
//
//        void DrawGridWithoutBorder(int x, int y)
//        {
//            
//                x * Zoom, y * Zoom,
//                Zoom, Zoom);
//        }
//
//
        #endregion
        #region Public

        public Bitmap GetGridImage()
        {
            return PrepareImage();
        }

        public void ChangeCellStatus(int x, int y, int status)
        {
            if (Running)
            {
                return;
            }

            CurrentGrid.ChangeCellValue(x, y, status);
        }

        public void ChangeCellStatus(int x, int y)
        {
            if (Running)
            {
                return;
            }

            CurrentGrid.ChangeCellValue(x, y);
        }

        public bool IsSimulationRunning()
        {
            return Running;
        }

        public void ResizeGrid(int sizeX, int sizeY)
        {
            if (Running)
            {
                return;
            }

            CurrentGrid.Resize(sizeX, sizeY);
            ClearGrid();
        }
        public void ClearGrid()
        {
            if (Running)
            {
                return;
            }
            CurrentGrid.Clear();
            Solver.Clear();
            OriginGrains.Clear();
            CurrentBitmap = new Bitmap(Grid.SizeX * Zoom, Grid.SizeY * Zoom, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
        }

        public void SetNeighborhoodType(int neighborhood)
        {
            _Neighborhood.SetNeighborhood(new List<int>() { neighborhood });
        }


        public void RunCASimulation(IProgress<Bitmap> progress)
        {
            if(Running)
            {
                return;
            }
            Running = true;
            CalculateNextGrid(progress);
        }

        public void StopCASimulation()
        {
            Running = false;
        }
        public void NextStepCASimulation(IProgress<Bitmap> progress)
        {
            if (Running)
            {
                return;
            }

            CalculateNextGrid(progress,false);
        }

        public int GetCellStatus(int x, int y)
        {
            return CurrentGrid.Cells[x, y].State;
        }

        internal void EraseNucleonsWithHigherId(int maxCellID)
        {
            for(int x = 0; x < Grid.SizeX; x++)
            {
                for(int y = 0; y < Grid.SizeY; y++)
                {
                    if(CurrentGrid.Cells[x,y].Id >= maxCellID)
                    {
                        CurrentGrid.Cells[x, y].Id = -1;
                        CurrentGrid.Cells[x, y].ChangeState(0);
                    }
                }
            }
        }
        #endregion
        #endregion
    }

}
