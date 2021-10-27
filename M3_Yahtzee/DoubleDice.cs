using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3_Yahtzee
{
    class DoubleDice : CupOfDices
    {
        public bool IsPair => this[0] == this[1];
        public DoubleDice() : base(2) { }
    }
}
