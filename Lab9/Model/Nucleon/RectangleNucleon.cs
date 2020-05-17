using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class RectangleNucleon : Nucleon
    {
        double SideRatio;
        double YRatio;
        double XRatio;
        double CosAngle;
        double SinAngle;
        double FinalMultiplier;

        public RectangleNucleon(Point position, double rotation, double firstRatio, double secondRatio) : base(position)
        {
            CosAngle = Math.Cos(rotation * Math.PI / 180.0);
            SinAngle = Math.Sin(rotation * Math.PI / 180.0);

            SideRatio = firstRatio / secondRatio;

            YRatio = firstRatio / Math.Max(firstRatio, secondRatio);
            XRatio = secondRatio / Math.Max(firstRatio, secondRatio);
            FinalMultiplier = Math.Max(firstRatio, secondRatio) / Math.Min(firstRatio, secondRatio) * 2;
        }

        public override double CalculateChangeStateTime(Point cellPosition)
        {
            var diffX = (cellPosition.X - Position.X);
            var diffY = (cellPosition.Y - Position.Y);
            double x0 = diffX * CosAngle - diffY * SinAngle;
            double y0 = diffX * SinAngle + diffY * CosAngle;


            double valToReturn = 0.0;
            if (y0 != 0)
            {
                double ratio = Math.Abs(x0 / y0);

                if (ratio <= SideRatio)
                {
                    valToReturn += Math.Abs(y0) * YRatio;
                }
                else
                {
                    valToReturn += Math.Abs(x0) * XRatio;
                }

            }
            else
            {
                valToReturn += Math.Abs(x0) * XRatio;
            }
            return valToReturn * FinalMultiplier + Iteration;
        }
    }
}
