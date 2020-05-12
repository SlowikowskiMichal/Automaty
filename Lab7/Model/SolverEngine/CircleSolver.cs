using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class CircleSolver : SolverEngine
    {
        List<Point> FrontPoints;
        NeighborhoodManager _Neighborhood;

        public CircleSolver()
        {
            FrontPoints = new List<Point>();
            _Neighborhood = NeighborhoodManager.GetInstance();
        }

        public override void Setup()
        {
            List<Point> OriginPoints = GridController.GetInstance().OriginGrains;
            Grid CurrentGrid = GridController.GetInstance().CurrentGrid;
            for (int i = FrontPoints.Count - 1; i >= 0; i--)
            {
                if (CurrentGrid.Cells[FrontPoints[i].X, FrontPoints[i].Y].State == 1)
                {
                    FrontPoints.RemoveAt(i);
                }
            }
            foreach (Point origP in OriginPoints)
            {
                Cell origCell = CurrentGrid.Cells[origP.X, origP.Y];
                var neighborsPoints = _Neighborhood.GetNeighborhood(origP.X, origP.Y, Grid.SizeX, Grid.SizeY).Where(p => CurrentGrid.Cells[p.X, p.Y].State == 2 || CurrentGrid.Cells[p.X, p.Y].State == 0);
                foreach (Point nP in neighborsPoints)
                {
                    Cell cell = CurrentGrid.Cells[nP.X, nP.Y];
                    cell.ChangeState(2);
                    cell.OriginPosition = origCell.OriginPosition;
                    cell.Id = origCell.Id;
                    cell.Time = (int)cell.CurrentPosition.DistanceBettwenPoints(cell.OriginPosition);

                }
                FrontPoints.AddRange(neighborsPoints);
            }
        }


        public override List<Point> Run(Grid CurrentGrid)
        {
            List<Point> ChangedPoints = new List<Point>();
            base.Run(CurrentGrid);
            for (int i = FrontPoints.Count - 1; i >= 0; i--)
            {
                Point frontalPoint = FrontPoints[i];
                if (CurrentGrid.Cells[frontalPoint.X, frontalPoint.Y].Time < Iteration)
                {
                    List<Point> nList = _Neighborhood.GetNeighborhood(frontalPoint.X, frontalPoint.Y, Grid.SizeX, Grid.SizeY)
                        .Where(v => CurrentGrid.GetCellState(v.X, v.Y) == 0).ToList();
                    foreach (Point newFrontalPoint in nList)
                    {
                        Cell cell = CurrentGrid.Cells[newFrontalPoint.X, newFrontalPoint.Y];
                        cell.ChangeState(2);
                        cell.Id = CurrentGrid.Cells[frontalPoint.X, frontalPoint.Y].Id;
                        cell.OriginPosition = CurrentGrid.Cells[frontalPoint.X, frontalPoint.Y].OriginPosition;
                        cell.Time = cell.CurrentPosition.DistanceBettwenPoints(cell.OriginPosition) * 1.1;
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

        internal override void Clear()
        {
            base.Clear();
            FrontPoints.Clear();
            
        }
    }
}

