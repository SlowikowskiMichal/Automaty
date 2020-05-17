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
            AddNucleonsAction = new Action(AddCircleNucleons);
        }

        private void AddCircleNucleons()
        {
            gridController.AddCircleCells(NucleonAmount);
        }

        public override string ToString()
        {
            return $"Koło, Opóźnienie: {Delay}, Ilość: {NucleonAmount}";
        }
    }
}
