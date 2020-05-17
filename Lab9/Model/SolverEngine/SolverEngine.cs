using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    abstract class SolverEngine
    {
        public static bool Change = false;
        public static double Iteration = 0;
        protected NeighborhoodManager _Neighborhood;

        public SolverEngine()
        {
            _Neighborhood = NeighborhoodManager.GetInstance();
        }

        abstract public List<Point> Setup();

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
