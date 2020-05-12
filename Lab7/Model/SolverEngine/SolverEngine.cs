using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    abstract class SolverEngine
    {
        public static bool Change = false;
        public static int Iteration = 0;

        abstract public void Setup();

        virtual public List<Point> Run(Grid currentGrid)
        {
            Change = false;
            SolverEngine.Iteration++;
            return null;
        }

        virtual internal void Clear()
        {
            Iteration = 0;
        }
    }
}
