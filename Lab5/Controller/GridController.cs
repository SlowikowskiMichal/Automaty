using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Diagnostics;

namespace Lab5
{
    class GridController
    {
        #region Attributes

        public List<Point> OriginGrains { get; internal set; }
        public int NumberOfFreeCells { get; private set; }

        public int Iteration;
        SolidBrush[] GridBrushes = new SolidBrush[] { new SolidBrush(Color.White), new SolidBrush(Color.Blue), new SolidBrush(Color.Red) };
        SolidBrush GridBrush = new SolidBrush(Color.LightGray);
        Grid CurrentGrid;
        Grid NextGrid;

        readonly static object synLock = new object();

        public bool DrawGrid;
        public int Zoom;

        bool Running = false;

        #endregion

        #region Constructors

        static GridController _Instance;

        public static GridController GetInstance()
        {
            if (_Instance == null)
            {
                _Instance = new GridController(100, 100, 0);
            }
            return _Instance;
        }

        public void LockSimulation(bool flag)
        {
            Running = flag;
        }

        GridController(int sizeX, int sizeY, int boundaryCondition, bool drawGrid = false, int zoom = 1)
        {

            //GRID
            CurrentGrid = new Grid(sizeX, sizeY);
            NextGrid = new Grid(sizeX, sizeY);
            Zoom = zoom;
            DrawGrid = drawGrid;

            //GRID OPTIONS
            OriginGrains = new List<Point>();
            Iteration = 1;
        }

        #endregion

        #region Methods
        #region Private
        void CalculateNextGridFromCoordinates(int startX, int startY, int endX, int endY)
        {
            //Faza 1
            for (int x = startX; x < endX; x++)
            {
                for (int y = startY; y < endY; y++)
                {
                    if (CurrentGrid.GetCellState(x, y) == 0)
                    {
                        if (CurrentGrid.Cells[x,y].Time <= Iteration * 1.1)
                        {

                            CurrentGrid.Cells[x, y].ChangeState(2);
                        }
                    }
                }
            }
            //Faza 2
            for (int x = startX; x < endX; x++)
            {
                for (int y = startY; y < endY; y++)
                {
                    if (CurrentGrid.GetCellState(x, y) == 2)
                    {
                        CurrentGrid.Cells[x, y].ChangeState(1);
                        NumberOfFreeCells--;
                    }
                }
            }
        }

        public void CalculateNextGrid(IProgress<Bitmap> progress, bool multipleSteps = true)
        {
            NumberOfFreeCells = 0;
            for (int x = 0; x < Grid.SizeX; x++)
            {
                for (int y = 0; y < Grid.SizeY; y++)
                {
                    if(CurrentGrid.Cells[x,y].State != 1)
                    {
                        NumberOfFreeCells++;
                    }
                }
            }

            Running = true;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            do
            {
                CalculateNextGridFromCoordinates(0, 0, Grid.SizeX, Grid.SizeY);
                Iteration++;
                //progress.Report(PrepareImage());
            } while (Running && multipleSteps && NumberOfFreeCells > 0);
            sw.Stop();
            Debug.WriteLine($"Elapsed Time: {sw.Elapsed}");
            Running = false;
        }

        private Bitmap PrepareImage()
        {
            var bmp = new Bitmap(Grid.SizeX * Zoom, Grid.SizeY * Zoom, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);

            using (var g = Graphics.FromImage(bmp))
            {
                if (DrawGrid)
                {
                    g.FillRectangle(GridBrush, 0, 0, Grid.SizeX * Zoom, Grid.SizeY * Zoom);
                }


                Action<int, int, SolidBrush, Graphics> drawAction;

                if (DrawGrid && Zoom > 3)
                {
                    drawAction = new Action<int, int, SolidBrush, Graphics>(DrawGridWithBorder);
                }
                else
                {
                    drawAction = new Action<int, int, SolidBrush, Graphics>(DrawGridWithoutBorder);
                }


                for (int i = 0; i < Grid.SizeX; i++)
                {
                    for (int j = 0; j < Grid.SizeY; j++)
                    {
                        drawAction.Invoke(i, j, GridBrushes[CurrentGrid.Cells[i, j].State], g);
                    }
                }
            }
            return bmp;
        }

        void DrawGridWithBorder(int x, int y, Brush b, Graphics panelGraphics)
        {
            panelGraphics.
                FillRectangle(b,
                x * Zoom + 1, y * Zoom + 1,
                Zoom - 2, Zoom - 2);

        }

        void DrawGridWithoutBorder(int x, int y, Brush b, Graphics panelGraphics)
        {
            panelGraphics.
                FillRectangle(b,
                x * Zoom, y * Zoom,
                Zoom, Zoom);
        }


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
            OriginGrains.Clear();
            NextGrid.Resize(sizeX, sizeY);
        }
        public void ClearGrid()
        {
            if (Running)
            {
                return;
            }
            CurrentGrid.Clear();
            OriginGrains.Clear();
            NextGrid.Clear();
            Iteration = 1;
        }

        public void RunCASimulation(IProgress<Bitmap> progress)
        {
            if (Running)
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

            CalculateNextGrid(progress, false);
        }

        public int GetCellStatus(int x, int y)
        {
            return CurrentGrid.Cells[x, y].State;
        }

        internal void AddGrainOriginPoints(List<Point> pointsToDraw, int v)
        {
            OriginGrains.AddRange(pointsToDraw);
            foreach(Point p in pointsToDraw)
            {
                CurrentGrid.Cells[p.X, p.Y].Id = v;
                CurrentGrid.Cells[p.X, p.Y].ChangeState(1);
            }
            RecalculateOriginForGrid();
        }

        private void RecalculateOriginForGrid()
        {
            int nThreads = 4;
            Thread[] calculations = new Thread[nThreads];
            int x = Grid.SizeX / 2;
            int y = Grid.SizeY / 2;
            NextGrid.Copy(CurrentGrid);
            calculations[0] = new Thread(() => RecalcalculateOriginForCoords(0, 0, x, y));
            calculations[1] = new Thread(() => RecalcalculateOriginForCoords(x, 0, Grid.SizeX, y));
            calculations[2] = new Thread(() => RecalcalculateOriginForCoords(0, y, x, Grid.SizeY));
            calculations[3] = new Thread(() => RecalcalculateOriginForCoords(x, y, Grid.SizeX, Grid.SizeY));
            foreach (Thread task in calculations)
            {
                task.Start();
            }
            foreach (Thread task in calculations)
            {
                task.Join();
            }
            CurrentGrid.Copy(NextGrid);
        }

        private void RecalcalculateOriginForCoords(int xStart, int yStart, int xEnd, int yEnd)
        {
            for (int x = xStart; x < xEnd; x++)
            {
                for (int y = yStart; y < yEnd; y++)
                {
                    Cell c = CurrentGrid.Cells[x, y];
                    if (c.State == 0)
                    {
                        var distance = double.MaxValue;
                        var tempDistance = c.Time;
                        Point grainLocation = new Point(-1, -1);
                        foreach (Point p in OriginGrains)
                        {
                            tempDistance = Math.Pow(p.X - x, 2.0) + Math.Pow(p.Y - y, 2.0);
                            if (tempDistance < distance)
                            {
                                grainLocation = p;
                                distance = tempDistance;
                            }
                        }
                        distance = Math.Sqrt(distance);
                        lock (synLock)
                        {
                            NextGrid.Cells[x, y].Time = distance;
                            NextGrid.Cells[x, y].Id = CurrentGrid.Cells[grainLocation.X, grainLocation.Y].Id;
                        }
                    }
                }
            }
        }

        internal void RemoveGrainOriginPoints(List<Point> pointsToDraw)
        {
            foreach (Point p in pointsToDraw)
            {
                CurrentGrid.Cells[p.X, p.Y].ChangeState(0);
                OriginGrains.Remove(p);
            }
            if(OriginGrains.Count > 0)
            {
                RecalculateOriginForGrid();
            }
            else
            {
                CurrentGrid.Clear();
                Iteration = 1;
            }
            
        }

        internal void ChangeCellId(int x, int y, int v)
        {
            CurrentGrid.Cells[x, y].Id = v;
        }
    }
    #endregion
    #endregion
}


