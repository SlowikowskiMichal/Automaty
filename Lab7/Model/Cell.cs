using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Cell
    {
        public int State { get; private set; }
        public int Id { get; set; }

        public Cell()
        {
            State = 0;
        }


        public Cell(Cell otherCell)
        {
            this.State = otherCell.State;
            this.Id = otherCell.Id;
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
        }
    }
}