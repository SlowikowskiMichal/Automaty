using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class CircleSolver : FrontalSolverEngine
    {
        public override void Setup()
        {
            base.Setup();
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
    }
}

