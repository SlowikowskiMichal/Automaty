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
        public override List<Point> Setup()
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

            return FrontPoints;
        }

        internal override void Clear()
        {
            base.Clear();
            FrontPoints.Clear();
        }
    }
}
