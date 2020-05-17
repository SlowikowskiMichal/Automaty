using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class CircleNucleon : Nucleon
    {
        double RadiusMultiplier;
        public CircleNucleon(Point position, double radiusMultiplier = 1.1) : base(position)
        {
            RadiusMultiplier = radiusMultiplier;
        }

        public override double CalculateChangeStateTime(Point cellPosition)
        {
            return cellPosition.DistanceBettwenPoints(Position) * RadiusMultiplier;
        }
    }
}
