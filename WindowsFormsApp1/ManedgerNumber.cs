using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class ManedgerNumber
    {
        public ManedgerNumber(int Min, int Max)
        {
            _min = Min;
            _max = Max;
        }
        public int Now { get; private set; }

        private int _min;
        private int _max;

        public void Step()
        {
            Now += 1;
            Clamp();
        }

        private void Clamp()
        {
            if (Now > _max)
                Now = _min;
            else if (Now < _min)
                Now = _max;

        }
    }
}
