using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    abstract class FrontalSolverEngine : SolverEngine
    {
        static protected List<Point> FrontPoints;

        public FrontalSolverEngine()
        {
            FrontPoints = new List<Point>();
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

        internal override void Clear()
        {
            base.Clear();
            FrontPoints.Clear();
        }
    }
}
