﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class DelayNucleon
    {
        protected int Delay;
        protected int NucleonAmount;
        protected int CurrentTime;

        protected GridController gridController;

        protected Action AddNucleonsAction;

        public DelayNucleon(int nucleonAmount,  int delay)
        {
            Delay = delay;
            NucleonAmount = nucleonAmount;
            gridController = GridController.GetInstance();
            CurrentTime = 0;
            AddNucleonsAction = new Action(() => Debug.WriteLine("Delay Nucleon Default Action"));
        }

        public void AddNucleons()
        {
            CurrentTime++;
            if(CurrentTime > Delay)
            {
                CurrentTime = 0;
                AddNucleonsAction.Invoke();
            }
        }
    }
}
