using Lab7.Controller;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;

namespace Lab7
{
    class GridController
    {
        #region Attributes

        NeighborhoodManager _Neighborhood;

        public NeighborhoodManager Neighborhood { get { return _Neighborhood; } private set { _Neighborhood = value; } }
        public int Iteration;
        BoundaryConditions BoundaryCondition;
        SolidBrush GridBrush = new SolidBrush(Color.LightGray);
        Grid CurrentGrid;
        Grid NextStepGrid;

        public bool DrawGrid;
        public int Zoom;

        bool Running = false;

        readonly static object synLock = new object();
        #endregion

        #region Constructors

        static GridController _Instance;

        public static GridController GetInstance()
        {
            if(_Instance == null)
            {
                _Instance = new GridController(100, 100, 0);
                _Instance._Neighborhood = new NeighborhoodManager(0);
            }
            return _Instance;
        }


        GridController(int sizeX, int sizeY, int boundaryCondition, bool drawGrid = false, int zoom = 1)
        {

            //GRID
            CurrentGrid = new Grid(sizeX, sizeY);
            NextStepGrid = new Grid(sizeX, sizeY);

            Zoom = zoom;
            DrawGrid = drawGrid;

            //GRID OPTIONS
            BoundaryCondition = (BoundaryConditions)boundaryCondition;
            //.SetNeighborhood(new List<int>() { neighborhoodType });
            Iteration = 0;
        }

        #endregion

        #region Methods
        #region Private
        void CalculateNextGridFromCoordinates(int startX, int startY, int endX, int endY)
        {
            Random r = new Random();

            List<Point> n;

            for (int x = startX; x < endX; x++)
            {
                for (int y = startY; y < endY; y++)
                {
                    n = _Neighborhood.GetNeighborhood(x, y, Grid.SizeX, Grid.SizeY, BoundaryCondition);

                    int aliveNeighborhoodsCount = n.Where(p => CurrentGrid.GetCellState(p.X, p.Y) == 1).Count();

                    CalculateNewState(CurrentGrid.Cells[x, y].State, x, y, aliveNeighborhoodsCount);
                }
            }
        }

        void CalculateNewState(int state, int x, int y, int aliveCount)
        {

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
            int nThreads = 4;
            Thread[] calculations = new Thread[nThreads];
            int x = Grid.SizeX / 2;
            int y = Grid.SizeY / 2;

            Running = true;
            do
            {
                NextStepGrid.Copy(CurrentGrid, 0, 0, Grid.SizeX, Grid.SizeY);
                calculations[0] = new Thread(() => CalculateNextGridFromCoordinates(0, 0, x, y));
                calculations[1] = new Thread(() => CalculateNextGridFromCoordinates(x, 0, Grid.SizeX, y));
                calculations[2] = new Thread(() => CalculateNextGridFromCoordinates(0, y, x, Grid.SizeY));
                calculations[3] = new Thread(() => CalculateNextGridFromCoordinates(x, y, Grid.SizeX, Grid.SizeY));
                foreach (Thread task in calculations)
                {
                    task.Start();
                }
                foreach (Thread task in calculations)
                {
                    task.Join();
                }
                Iteration++;
                CurrentGrid.Copy(NextStepGrid);
                progress.Report(PrepareImage());
            } while (Running && multipleSteps);
            Running = false;
        }

        private Bitmap PrepareImage()
        {
            var bmp = new Bitmap(Grid.SizeX * Zoom, Grid.SizeY * Zoom, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
            SolidBrush b = new SolidBrush(Color.White);
            using (var g = Graphics.FromImage(bmp))
            {
                if (DrawGrid)
                {
                    g.FillRectangle(GridBrush, 0, 0, Grid.SizeX*Zoom, Grid.SizeY*Zoom);
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
                        var state = CurrentGrid.Cells[i, j].State;
                        if (state == 0)
                        {
                            b.Color = Color.White;
                        }
                        else if(state == 1)
                        {
                            b.Color = ColorTranslator.FromHtml(ColorManager.indexColors[CurrentGrid.Cells[i, j].Id % ColorManager.indexColors.Length]);
                        }

                        drawAction.Invoke(i, j, b, g);
                    }
                }
            }
            return bmp;
        }

        void DrawGridWithBorder(int x, int y, SolidBrush b, Graphics panelGraphics)
        {
            panelGraphics.
                FillRectangle(b,
                x * Zoom + 1, y * Zoom + 1,
                Zoom - 2, Zoom - 2);

        }

        void DrawGridWithoutBorder(int x, int y, SolidBrush b, Graphics panelGraphics)
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
            NextStepGrid.Resize(sizeX, sizeY);
        }
        public void ClearGrid()
        {
            if (Running)
            {
                return;
            }
            CurrentGrid.Clear();
            NextStepGrid.Clear();
        }
        public void SetBoundaryCondition(int boundaryCondition)
        {
            BoundaryCondition = (BoundaryConditions)boundaryCondition;
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
