using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public double DistanceBettwenPoints(Point otherPoint)
        {
            return Math.Sqrt(SqrDistanceBettwenPoints(otherPoint));
        }

        public double SqrDistanceBettwenPoints(Point otherPoint)
        {
            return Math.Pow(this.X - otherPoint.X, 2) + Math.Pow(this.Y - otherPoint.Y, 2);
        }

        internal void Set(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
