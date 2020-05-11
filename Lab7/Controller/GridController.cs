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

        SolverEngine Solver;

        public NeighborhoodManager Neighborhood { get { return _Neighborhood; } private set { _Neighborhood = value; } }
        public int Iteration;

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
                _Instance = new GridController(100, 100);
                _Instance._Neighborhood = NeighborhoodManager.GetInstance();
                _Instance.Solver = new ClassicSolverEngine();
            }
            return _Instance;
        }


        GridController(int sizeX, int sizeY, bool drawGrid = false, int zoom = 1)
        {

            //GRID
            CurrentGrid = new Grid(sizeX, sizeY);
            NextStepGrid = new Grid(sizeX, sizeY);

            Zoom = zoom;
            DrawGrid = drawGrid;

            //GRID OPTIONS
            Iteration = 0;
        }

        #endregion

        #region Methods
        #region Private

        public void SetBoundaryCondition(int boundary)
        {
            _Neighborhood.Boundary = (BoundaryConditions)boundary;
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
            Running = true;
            do
            {
                CurrentGrid.Copy(Solver.Run(CurrentGrid));
                progress.Report(PrepareImage());
            } while (Running && multipleSteps && SolverEngine.Change);
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
