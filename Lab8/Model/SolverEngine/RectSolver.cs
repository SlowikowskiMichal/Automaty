using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class RectSolver : FrontalSolverEngine
    {

        double CosAngle;
        double SinAngle;
        double FirstSideRatio;
        double SecondSideRatio;
        double SideRatio;
        double YRatio;
        double XRatio;

        public override List<Point> Setup()
        {
            base.Setup();
            GridController gc = GridController.GetInstance();
            var Angle = (double)gc.RectRotation;
            CosAngle = Math.Cos(Angle * Math.PI / 180.0);
            SinAngle = Math.Sin(Angle * Math.PI / 180.0);
            FirstSideRatio = (double)gc.RectRatioFirst;
            SecondSideRatio = (double)gc.RectRatioSecond;
            SideRatio = FirstSideRatio / SecondSideRatio;

            YRatio = FirstSideRatio / Math.Max(FirstSideRatio, SecondSideRatio);
            XRatio = SecondSideRatio / Math.Max(FirstSideRatio, SecondSideRatio);

            Grid CurrentGrid = GridController.GetInstance().CurrentGrid;
            List<Point> OriginPoints = GridController.GetInstance().OriginGrains;

            foreach (Point origP in OriginPoints)
            {
                Cell origCell = CurrentGrid.Cells[origP.X, origP.Y];
                var neighborsPoints = _Neighborhood.GetNeighborhood(origP.X, origP.Y, Grid.SizeX, Grid.SizeY)
                    .Where(p => CurrentGrid.Cells[p.X, p.Y].State == 2 || CurrentGrid.Cells[p.X, p.Y].State == 0);
                foreach (Point nP in neighborsPoints)
                {
                    Cell cell = CurrentGrid.Cells[nP.X, nP.Y];
                    cell.ChangeState(2);
                    cell.OriginPosition = origCell.OriginPosition;
                    cell.Id = origCell.Id;
                    cell.Time = CalculateTime(cell.OriginPosition.X, cell.OriginPosition.Y, nP.X, nP.Y);

                }
                FrontPoints.AddRange(neighborsPoints);
            }

            return FrontPoints;
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
                        Cell cell = CurrentGrid.Cells[newFrontalPoint.X, newFrontalPoint.Y];
                        cell.ChangeState(2);
                        cell.Id = CurrentGrid.Cells[frontalPoint.X, frontalPoint.Y].Id;
                        cell.OriginPosition = CurrentGrid.Cells[frontalPoint.X, frontalPoint.Y].OriginPosition;
                        cell.Time = CalculateTime(cell.OriginPosition.X, cell.OriginPosition.Y, newFrontalPoint.X, newFrontalPoint.Y);
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

        private double CalculateTime(int x1, int y1, int x2, int y2)
        {
            var diffX = (x2 - x1);
            var diffY = (y2 - y1);
            double x0 = diffX * CosAngle - diffY * SinAngle;
            double y0 = diffX * SinAngle + diffY * CosAngle;

            if(y0 != 0)
            {
                double ratio = Math.Abs(x0 / y0);
               
                if (ratio <= SideRatio)
                {
                    return Math.Abs(y0) * YRatio;
                }
                else
                {
                    return Math.Abs(x0) * XRatio;
                }

            }
            else
            {
                return Math.Abs(x0) * XRatio;
            }

        }
    }
}
