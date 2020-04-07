using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Lab3
{
    class GridController
    {
        #region Attributes
        readonly Neighborhood[] ImplementedNeighborhood = {new MooresNeighborhood(), new NeumannNeighborhood(),
            new HexagonalLeftNeighborhood(), new HexagonalRightNeighborhood(), new HexagonalRandomNeighborhood(),
            new PentagonalLeftNeighborhood(), new PentagonalRightNeighborhood(), new PentagonalTopNeighborhood(),
            new PentagonalBottomNeighborhood(), new PentagonalRandomNeighborhood() };

        Neighborhood Neighborhood;

        BoundaryConditions BoundaryCondition;

        Grid CurrentGrid;
        Grid NextStepGrid;

        List<int> AliveRule;
        List<int> DeadRule;

        bool Running = false;

        readonly static object synLock = new object();
        #endregion

        #region Constructors

        public GridController(int sizeX, int sizeY, int boundaryCondition, int neighborhoodType)
        {

            //GRID
            CurrentGrid = new Grid(sizeX, sizeY);
            NextStepGrid = new Grid(sizeX, sizeY);

            //RULES
            AliveRule = new List<int>();
            DeadRule = new List<int>();

            //GRID OPTIONS
            BoundaryCondition = (BoundaryConditions)boundaryCondition;
            Neighborhood = ImplementedNeighborhood[neighborhoodType];
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
                    n = Neighborhood.GetNeighborhood(x, y, Grid.SizeX, Grid.SizeY, BoundaryCondition);

                    int aliveNeighborhoodsCount = n.Where(p => CurrentGrid.Cells[p.X, p.Y].State == 1).Count();

                    CalculateNewState(CurrentGrid.Cells[x, y].State, x, y, aliveNeighborhoodsCount);
                }
            }
        }

        void CalculateNewState(int state, int x, int y, int aliveCount)
        {
            if (state == 1)
            {
                if (DeadRule.Contains(aliveCount))
                {
                    lock (synLock)
                    {
                        NextStepGrid.Cells[x, y].ChangeState();
                    }
                }
            }
            else
            {
                if (AliveRule.Contains(aliveCount))
                {
                    lock (synLock)
                    {
                        NextStepGrid.Cells[x, y].ChangeState();
                    }
                }
            }
        }

        public void CalculateNextGrid(IProgress<Grid> progress, bool onlyOneStep = false)
        {
            int nThreads = 4;
            Thread[] calculations = new Thread[nThreads];
            int x = Grid.SizeX / 2;
            int y = Grid.SizeY / 2;

            Running = true;
            while (Running || onlyOneStep)
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
                CurrentGrid.Copy(NextStepGrid);
                progress.Report(NextStepGrid);
            }
            Running = false;
        }
        #endregion
        #region Public
        public void ResizeGrid(int sizeX, int sizeY)
        {
            if (Running)
            {
                throw new FieldAccessException("Nie można zmienić rozmiaru siatki podczas obliczeń.");
            }

            CurrentGrid.Resize(sizeX, sizeY);
            NextStepGrid.Resize(sizeX, sizeY);
        }
        public void ClearGrid()
        {
            if (Running)
            {
                throw new FieldAccessException("Nie można wyczyścić siatki podczas obliczeń.");
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
            Neighborhood = ImplementedNeighborhood[neighborhood];
        }

        public void SetAliveRule(List<int> aliveRule)
        {
            AliveRule = aliveRule;
        }

        public void SetDeadRule(List<int> deadRule)
        {
            DeadRule = deadRule;
        }

        public void RunCASimulation(IProgress<Grid> progress)
        {
            if (Running)
            {
                throw new FieldAccessException("Nie można uruchomić obliczeń więcej niż raz jednocześnie.");
            }
            Running = true;
            CalculateNextGrid(progress);
        }

        public void StopCASimulation()
        {
            Running = false;
        }
        public void NextStepCASimulation(IProgress<Grid> progress)
        {
            if (Running)
            {
                throw new FieldAccessException("Nie można uruchomić obliczeń więcej niż raz jednocześnie.");
            }

            CalculateNextGrid(progress, true);
        }
        #endregion
        #endregion
    }

}
