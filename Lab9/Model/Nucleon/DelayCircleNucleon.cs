using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class DelayCircleNucleon : DelayNucleon
    {
        public DelayCircleNucleon(int nucleonAmount, int delay): base(nucleonAmount, delay)
        {
            AddNucleonsAction = new Action<List<Point>>(AddCircleNucleons);
        }

        private void AddCircleNucleons(List<Point> emptyCellPoints)
        {
            gridController.AddCircleCells(NucleonAmount, emptyCellPoints);
        }

        public override string ToString()
        {
            return $"Koło, Opóźnienie: {Delay}, Ilość: {NucleonAmount}";
        }
    }
}
