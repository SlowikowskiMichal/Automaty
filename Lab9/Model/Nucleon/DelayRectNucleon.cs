using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class DelayRectNucleon : DelayNucleon
    {

        double Rotation;
        double FirstSideRatio;
        double SecondSideRatio;
        
        public DelayRectNucleon(int nucleonAmount, int delay, double? rotation, double? firstRotation, double? secondRotation ) : base(nucleonAmount, delay)
        {
            if(rotation == null || firstRotation == null || secondRotation == null)
            {
                AddNucleonsAction = new Action<List<Point>>(AddRandomRectNucleons);
            }
            else
            {
                this.Rotation = rotation.Value;
                this.FirstSideRatio = firstRotation.Value;
                this.SecondSideRatio = secondRotation.Value;
                AddNucleonsAction = new Action<List<Point>>(AddRectNucleons);
            }
        }

        void AddRandomRectNucleons(List<Point> emptyPointList)
        {
            gridController.AddRandomRectangleCells(NucleonAmount, emptyPointList);
        }

        void AddRectNucleons(List<Point> emptyPointList)
        {
            gridController.AddRectangleCells(NucleonAmount,Rotation,FirstSideRatio,SecondSideRatio, emptyPointList);
        }

        public override string ToString()
        {
            string attr;
            if (AddNucleonsAction == AddRandomRectNucleons)
            {
                attr = "Losowe wartości";
            }
            else
            {
                attr = $"Kąt: {Rotation}, Stosunek X: {FirstSideRatio}, Y: {SecondSideRatio}";
            }

            return $"Prostokąt, Opóźnienie: {Delay}, Ilość: {NucleonAmount}, {attr}";
        }
    }
}
