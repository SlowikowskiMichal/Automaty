using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Point
    {
        public int X;
        public int Y;
        

        public Point(Point point)
        {
            this.X = point.X;
            this.Y = point.Y;
        }

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

        public static Point operator*(Point a, Point b)
        {
            return new Point(a.X * b.X, a.Y * b.Y);
        }
    }
}
