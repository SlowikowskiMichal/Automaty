using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Cell
    {
        public int State { get; private set; }
        public int Id { get; set; }

        public Cell()
        {
            State = 0;
        }

        public void ChangeState()
        {
            State = (State == 0) ? 1 : 0;
        }

        public void Reset()
        {
            State = 0;
        }
    }
}
