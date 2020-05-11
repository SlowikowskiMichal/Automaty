using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Cell
    {

        public Point CurrentPosition;
        public Point OriginPosition;

        public int State { get; private set; }
        public int Id { get; set; }

        public int Time;


        public Cell(int x, int y)
        {
            State = 0;
            Id = -1;
            CurrentPosition = new Point(x,y);
            OriginPosition = new Point(-1,-1);
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


        public void SetOriginFromCoords(int x, int y)
        {
            OriginPosition.X = x;
            OriginPosition.Y = y;
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
            OriginPosition = new Point(-1, -1);
            Time = -1;
        }
    }
}