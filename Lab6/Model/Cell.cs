using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Cell
    {
        public int State { get; private set; }
        public int Id { get; set; }
        public double Time { get; set; }
        public Cell()
        {
            State = 0;
            Id = 0;
            Time = double.MaxValue;
        }


        public Cell(Cell otherCell)
        {
            this.State = otherCell.State;
            this.Id = otherCell.Id;
        }

        public void ChangeState()
        {
            if (State == 0)
            {
                State = 2;
            }
            else if (State == 2)
            {
                State = 1;
            }
        }

        public void ChangeState(int state)
        {
            State = state;
        }

        public void Reset()
        {
            State = 0;
            Id = 0;
            Time = double.MaxValue;
        }
    }
}
