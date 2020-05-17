using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class FrontalSolverEngine : SolverEngine
    {
        static public List<Point> FrontPoints;

        public FrontalSolverEngine()
        {
            FrontPoints = new List<Point>();
        }
        public override List<Point> Setup()
        {
            Grid CurrentGrid = GridController.GetInstance().CurrentGrid;
            for (int i = FrontPoints.Count - 1; i >= 0; i--)
            {
                if (CurrentGrid.Cells[FrontPoints[i].X, FrontPoints[i].Y].State == 1)
                {
                    FrontPoints.RemoveAt(i);
                }
            }

            List<Point> OriginPoints = GridController.GetInstance().OriginGrains;

            foreach (Point origP in OriginPoints)
            {
                Cell origCell = CurrentGrid.Cells[origP.X, origP.Y];
                var neighborsPoints = _Neighborhood.GetNeighborhood(origP.X, origP.Y, Grid.SizeX, Grid.SizeY)
                    .Where(p => CurrentGrid.Cells[p.X, p.Y].State == 2 || CurrentGrid.Cells[p.X, p.Y].State == 0);
                foreach (Point nP in neighborsPoints)
                {
                    MoveCellToFrontalPoints(CurrentGrid.Cells[origP.X, origP.Y], CurrentGrid.Cells[nP.X, nP.Y]);

                }
                FrontPoints.AddRange(neighborsPoints);
            }

            return FrontPoints;
        }

        internal override void Clear()
        {
            base.Clear();
            FrontPoints.Clear();
        }

        public override List<Point> Run(Grid CurrentGrid)
        {
            base.Run(CurrentGrid);
            Iteration -= 0.9;
            List<Point> ChangedPoints = new List<Point>();
            for (int i = FrontPoints.Count - 1; i >= 0; i--)
            {
                Point frontalPoint = FrontPoints[i];
                if (CurrentGrid.Cells[frontalPoint.X, frontalPoint.Y].Time < Iteration)
                {
                    List<Point> nList = _Neighborhood.GetNeighborhood(frontalPoint.X, frontalPoint.Y, Grid.SizeX, Grid.SizeY)
                        .Where(v => CurrentGrid.GetCellState(v.X, v.Y) == 0).ToList();
                    foreach (Point newFrontalPoint in nList)
                    {
                        MoveCellToFrontalPoints(CurrentGrid.Cells[frontalPoint.X, frontalPoint.Y], CurrentGrid.Cells[newFrontalPoint.X, newFrontalPoint.Y]);
                        ChangedPoints.Add(newFrontalPoint);
                    }
                    FrontPoints.AddRange(nList);
                    CurrentGrid.Cells[frontalPoint.X, frontalPoint.Y].ChangeState(1);
                    FrontPoints.RemoveAt(i);
                    Change = true;
                    ChangedPoints.Add(frontalPoint);
                }
            }
            Change = Change || FrontPoints.Count > 0;
            return ChangedPoints;
        }

        private void MoveCellToFrontalPoints(Cell originCell, Cell cell)
        {
            cell.ChangeState(2);
            cell.Id = originCell.Id;
            cell.OriginPosition = originCell.OriginPosition;
            cell.Time = cell.OriginPosition.CalculateChangeStateTime(cell.CurrentPosition);
            
        }
    }
}
