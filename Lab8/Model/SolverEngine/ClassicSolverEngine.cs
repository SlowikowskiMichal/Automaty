using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab8
{
    class ClassicSolverEngine : SolverEngine
    {
        Grid CurrentGrid;
        Grid NextStepGrid;

        int x, y, nThreads;
        Task<List<Point>>[] calculations;

        List<int> DeadRule;
        List<int> AliveRule;
        public ClassicSolverEngine()
        {
        }

        public override List<Point> Run(Grid currentGrid)
        {
            base.Run(currentGrid);
            Change = false;
            CurrentGrid = currentGrid;
            NextStepGrid.Copy(CurrentGrid);
            List<Point> ChangedCells = new List<Point>();
            calculations[0] = Task<List<Point>>.Factory.StartNew(() => { return CalculateNextGridFromCoordinates(0, 0, x, y); });
            calculations[1] = Task<List<Point>>.Factory.StartNew(() => { return CalculateNextGridFromCoordinates(x, 0, Grid.SizeX, y); });
            calculations[2] = Task<List<Point>>.Factory.StartNew(() => { return CalculateNextGridFromCoordinates(0, y, x, Grid.SizeY); });
            calculations[3] = Task<List<Point>>.Factory.StartNew(() => { return CalculateNextGridFromCoordinates(x, y, Grid.SizeX, Grid.SizeY); });
            foreach (Task<List<Point>> task in calculations)
            {
                ChangedCells.AddRange(task.Result);
            }
            SolverEngine.Iteration++;
            currentGrid.Copy(NextStepGrid);
            return ChangedCells;
        }

        public override List<Point> Setup()
        {
            nThreads = 4;
            calculations = new Task<List<Point>>[nThreads];
            x = Grid.SizeX / 2;
            y = Grid.SizeY / 2;

            GridController gc = GridController.GetInstance();
            DeadRule = gc.DeadRule;
            AliveRule = gc.AliveRule;
            NextStepGrid = new Grid(Grid.SizeX, Grid.SizeY);
            return new List<Point>();
        }

        List<Point> CalculateNextGridFromCoordinates(int startX, int startY, int endX, int endY)
        {
            Random r = new Random();

            List<Point> n;

            List<Point> ChangedCells = new List<Point>();

            for (int x = startX; x < endX; x++)
            {
                for (int y = startY; y < endY; y++)
                {

                    n = _Neighborhood.GetNeighborhood(x, y, Grid.SizeX, Grid.SizeY);

                    int aliveNeighborhoodsCount = n.Where(p => CurrentGrid.GetCellState(p.X, p.Y) == 1).Count();
                    if (aliveNeighborhoodsCount > 0)
                    {
                        if(ChangeState(x, y, n.GroupBy(p => CurrentGrid.GetCellId(p.X, p.Y))
                            .OrderByDescending(g => g.Count())
                            .Select(g => g.Key).Where(v => v != -1)
                            .ToList()[0], CurrentGrid.Cells[x, y].State, aliveNeighborhoodsCount))
                        {
                            ChangedCells.Add(new Point(x, y));
                            Change = true;
                        }
                    }
                }
            }
            return ChangedCells;
        }

        bool ChangeState(int x, int y, int id, int state, int aliveCount)
        {

            if (state != 1)
            {

                if (AliveRule.Contains(aliveCount))
                {

                    NextStepGrid.Cells[x, y].ChangeState(1);
                    NextStepGrid.Cells[x, y].Id = id;
                    return true;
                }
            }
            else
            {
                if (DeadRule.Contains(aliveCount))
                {

                    NextStepGrid.Cells[x, y].ChangeState(0);
                    return true; 
                }
            }
            return false;
            /*
            NextStepGrid.Cells[x, y].ChangeState(1);
            NextStepGrid.Cells[x, y].Id = id;
            Change = true;
            */
        }
    }
}
