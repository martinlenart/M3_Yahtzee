using System;
using System.Collections.Generic;

namespace M3_Yahtzee
{
    class CupOfDices : ICupOfDices
    {
        protected List<DiceFace> dices;

        private int _count = 0;
        public int Count => _count;
        public DiceFace this[int idx]
        {
            get
            {
                /*
                if (Count <= 0)
                    throw new IndexOutOfRangeException("No dices in cup");
                if (idx < 0 || idx > Count - 1)
                    throw new IndexOutOfRangeException("Wrong idx");
                */

                return dices[idx];
            }
        }

        public DiceFace Highest
        {
            get
            {
                Sort();
                return this[Count - 1];
            }
        }
        public DiceFace Lowest
        {
            get
            {
                Sort();
                return this[0];
            }
        }

        public void Sort()
        {
            dices.Sort();
        }
        public void Shake()
        {
            var rnd = new Random();
            dices.Clear();
            for (int i = 0; i < Count; i++)
            {
                dices.Add((DiceFace)rnd.Next((int)DiceFace.One, (int)DiceFace.Six + 1));

                //To Test IsYahtzee
                //dices.Add(DiceFace.Four);

                //To Test IsLargeStraight
                //dices.Add(DiceFace.One + i%6);
            }
        }

        public override string ToString()
        {
            string sRet = $"Cup contains {Count} dices\n";
            for (int i = 0; i < Count; i++)
            {
                sRet += $"{this[i],8},";
                if ((i + 1) % 10 == 0)
                    sRet += "\n";
            }
            return sRet;
        }

        public CupOfDices()
        {
            dices = new List<DiceFace>();
        }
        public CupOfDices(int NrOfDices)
        {
            if (NrOfDices < 0 || NrOfDices > 100)
                throw new IndexOutOfRangeException("Wrong number of Dices");

            dices = new List<DiceFace>();
            _count = NrOfDices;

            Shake();
        }
    }
}
