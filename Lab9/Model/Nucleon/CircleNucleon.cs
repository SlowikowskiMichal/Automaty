using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class CircleNucleon : Nucleon
    {
        double RadiusMultiplier;
        public CircleNucleon(Point position, double radiusMultiplier = 1.1) : base(position)
        {
            RadiusMultiplier = radiusMultiplier;
        }

        CircleNucleon(Point position, double iteration, double radiusMultiplier = 1.1) : base(position,iteration)
        {
            RadiusMultiplier = radiusMultiplier;
        }

        public override double CalculateChangeStateTime(Point cellPosition)
        {
            return cellPosition.DistanceBettwenPoints(Position) * RadiusMultiplier + Iteration;
        }

        internal override Nucleon Clone()
        {
            return new CircleNucleon(new Point(Position), Iteration, RadiusMultiplier);
        }
    }
}
