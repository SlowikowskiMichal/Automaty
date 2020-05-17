using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class FrontalSolverEngine : SolverEngine
    {
        static public List<Point> FrontPoints;
        Neighborhood vonNeuman;
        public FrontalSolverEngine()
        {
            vonNeuman = new NeumannNeighborhood();
            FrontPoints = new List<Point>();
        }
        public override List<Point> Setup()
        {
            List<Point> pointsToUpdate = new List<Point>();
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
                if (origCell.State == 1 && _Neighborhood.GetNeighborhood(origP.X, origP.Y, Grid.SizeX, Grid.SizeY, vonNeuman)
                    .Exists(p => CurrentGrid.Cells[p.X, p.Y].Id != origCell.Id && CurrentGrid.Cells[p.X, p.Y].State == origCell.State))
                {
                    origCell.ChangeState(4);
                    pointsToUpdate.Add(origP);
                }
            }

            return pointsToUpdate.Concat(FrontPoints).ToList();
        }

        internal override void Clear()
        {
            base.Clear();
            FrontPoints.Clear();
        }

        public override List<Point> Run(Grid CurrentGrid)
        {
            base.Run(CurrentGrid);
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
                    if(_Neighborhood.GetNeighborhood(frontalPoint.X, frontalPoint.Y, Grid.SizeX, Grid.SizeY, vonNeuman)
                        .Exists(p=>CurrentGrid.Cells[p.X,p.Y].Id != CurrentGrid.Cells[frontalPoint.X, frontalPoint.Y].Id))
                    {
                        CurrentGrid.Cells[frontalPoint.X, frontalPoint.Y].ChangeState(4);
                    }
                    else
                    {
                        CurrentGrid.Cells[frontalPoint.X, frontalPoint.Y].ChangeState(1);
                    }
                    
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
