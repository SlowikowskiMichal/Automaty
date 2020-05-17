using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Cell
    {

        public Point CurrentPosition;
        public Nucleon OriginPosition;

        public int State { get; private set; }
        public int Id { get; set; }

        public double Time;


        public Cell(int x, int y)
        {
            State = 0;
            Id = -1;
            CurrentPosition = new Point(x,y);
            OriginPosition = null;
            Time = -1;
        }

        public Cell(Cell otherCell)
        {
            this.State = otherCell.State;
            this.Id = otherCell.Id;
            this.CurrentPosition = otherCell.CurrentPosition;
            this.OriginPosition = otherCell.OriginPosition;
            this.Time = otherCell.Time;
        }

        public void ChangeState()
        {
            State = (State == 0) ? 1 : 0;
        }

        public void ChangeState(int state)
        {
            State = state;
        }

        public void Reset()
        {
            State = 0;
            Id = -1;
            OriginPosition = null;
            Time = -1;
        }

        internal void SetAsCircleOrigin()
        {
            OriginPosition = new CircleNucleon(CurrentPosition);
        }

        internal void SetAsRectangleOrigin(double rotation, double firstSideRatio, double secondSideRatio)
        {
            OriginPosition = new RectangleNucleon(CurrentPosition,rotation, firstSideRatio,secondSideRatio);
        }
    }
}