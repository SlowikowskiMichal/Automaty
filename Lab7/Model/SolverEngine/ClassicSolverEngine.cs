using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab7
{
    class ClassicSolverEngine : SolverEngine
    {
        Grid CurrentGrid;
        Grid NextStepGrid;

        int x, y, nThreads;
        Thread[] calculations;


        public ClassicSolverEngine()
        {
            NextStepGrid = new Grid(Grid.SizeX,Grid.SizeY);
        }

        public override List<Point> Run(Grid currentGrid)
        {
            base.Run(currentGrid);
            Change = false;
            CurrentGrid = currentGrid;
            NextStepGrid.Copy(CurrentGrid);

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
            SolverEngine.Iteration++;
            return null;
        }

        public override List<Point> Setup()
        {
            nThreads = 4;
            calculations = new Thread[nThreads];
            x = Grid.SizeX / 2;
            y = Grid.SizeY / 2;
            return null;
        }

        void CalculateNextGridFromCoordinates(int startX, int startY, int endX, int endY)
        {
            Random r = new Random();

            List<Point> n;

            for (int x = startX; x < endX; x++)
            {
                for (int y = startY; y < endY; y++)
                {
                    if(CurrentGrid.Cells[x,y].State != 1)
                    {
                        n = _Neighborhood.GetNeighborhood(x, y, Grid.SizeX, Grid.SizeY);

                        int aliveNeighborhoodsCount = n.Where(p => CurrentGrid.GetCellState(p.X, p.Y) == 1).Count();
                        if(aliveNeighborhoodsCount > 0)
                        {
                            ChangeState(x, y,n.GroupBy(p=>CurrentGrid.GetCellId(p.X,p.Y))
                                .OrderByDescending(g => g.Count())
                                .Select(g=>g.Key).Where(v => v != -1)
                                .ToList()[0]);
                        }
 
                    }
                    
                }
            }
        }

        void ChangeState(int x, int y, int id)
        {

            NextStepGrid.Cells[x, y].ChangeState(1);
            NextStepGrid.Cells[x, y].Id = id;
            Change = true;
            
        }
    }
}
