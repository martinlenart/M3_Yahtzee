using System;
using System.Collections.Generic;

namespace M3_Yahtzee
{
    class CupOfDices : ICupOfDices
    {
        protected List<DiceFace> dices;

        private int _count = 0;
        public int Count => _count;

        DiceFace ICupOfDices.Highest => throw new NotImplementedException();

        DiceFace ICupOfDices.Lowest => throw new NotImplementedException();

        DiceFace ICupOfDices.this[int idx] => throw new NotImplementedException();

        public void Shake()
        {
            var rnd = new Random();
            dices.Clear();
            for (int i = 0; i < Count; i++)
            {
                dices.Add((DiceFace)rnd.Next((int)DiceFace.One, (int)DiceFace.Six + 1));

                #region Test code
                //To Test IsYahtzee
                //dices.Add(DiceFace.Four);

                //To Test IsLargeStraight
                //dices.Add(DiceFace.One + i%6);
                #endregion
            }
        }

        void ICupOfDices.Sort()
        {
            throw new NotImplementedException();
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
