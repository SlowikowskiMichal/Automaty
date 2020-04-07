using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Rule
    {
        static Rule instance;

        List<int> _born;
        List<int> _survive;
        const int MinNeighbours = 0;
        const int MaxNeighbours = 8;

        public List<int> Born {
            get => _born;
            set
            {
                if(value.Exists(v => v < MinNeighbours || MaxNeighbours < v))
                {
                    return;
                }
                _born = new List<int>(value);
            }
        }
        public List<int> Survive { get => _survive; set
            {
                if (value.Exists(v => v < MinNeighbours || MaxNeighbours < v))
                {
                    return;
                }
                _survive = new List<int>(value);
            }
        }

        private Rule()
        {
            _born = new List<int>(new int[] { 3 });
            _survive = new List<int>(new int[] { 2, 3 });
        }

        static public Rule Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Rule();
                }

                return instance;
            }
        }
    }
}
