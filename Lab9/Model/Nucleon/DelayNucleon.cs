using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class DelayNucleon
    {
        protected int Delay;
        protected int NucleonAmount;
        protected int CurrentTime;

        protected GridController gridController;

        protected Action<List<Point>> AddNucleonsAction;

        public DelayNucleon(int nucleonAmount,  int delay)
        {
            Delay = delay;
            NucleonAmount = nucleonAmount;
            gridController = GridController.GetInstance();
            CurrentTime = 0;
            AddNucleonsAction = new Action<List<Point>>((a) => Debug.WriteLine("Delay Nucleon Default Action"));
        }

        public void AddNucleons(List<Point> emptyCellPoints)
        {
            CurrentTime++;
            if(CurrentTime > Delay)
            {
                CurrentTime = 0;
                AddNucleonsAction.Invoke(emptyCellPoints);
            }
        }
    }
}
