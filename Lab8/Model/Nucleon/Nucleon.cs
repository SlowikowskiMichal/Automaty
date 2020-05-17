using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    abstract class Nucleon
    {

        protected Point Position;

        public Nucleon(Point position)
        {
            Position = position;
        }

        public virtual double CalculateChangeStateTime(Point cellPosition)
        {
            return 0.0;
        }
    }
}
