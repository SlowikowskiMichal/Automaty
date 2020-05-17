using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class RectangleNucleon : Nucleon
    {
        double SideRatio;
        double YRatio;
        double XRatio;
        double CosAngle;
        double SinAngle;

        public RectangleNucleon(Point position, double rotation, double firstRatio, double secondRatio) : base(position)
        {
            CosAngle = Math.Cos(rotation * Math.PI / 180.0);
            SinAngle = Math.Sin(rotation * Math.PI / 180.0);

            SideRatio = firstRatio / secondRatio;

            YRatio = firstRatio / Math.Max(firstRatio, secondRatio);
            XRatio = secondRatio / Math.Max(firstRatio, secondRatio);
        }

        public override double CalculateChangeStateTime(Point cellPosition)
        {
            var diffX = (cellPosition.X - Position.X);
            var diffY = (cellPosition.Y - Position.Y);
            double x0 = diffX * CosAngle - diffY * SinAngle;
            double y0 = diffX * SinAngle + diffY * CosAngle;

            if (y0 != 0)
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
