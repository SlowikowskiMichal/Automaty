using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    abstract class Nucleon
    {

        public Point Position;
        protected double Iteration;

        public Nucleon(Point position)
        {
            Position = position;
            Iteration = FrontalSolverEngine.Iteration;
        }

        public Nucleon(Point position, double iteration)
        {
            Position = position;
            Iteration = iteration;
        }

        public virtual double CalculateChangeStateTime(Point cellPosition)
        {
            return 0.0;
        }

        internal abstract Nucleon Clone();
    }
}
