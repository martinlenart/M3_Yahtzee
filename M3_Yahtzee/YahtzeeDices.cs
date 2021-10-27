namespace M3_Yahtzee
{
    class YahtzeeDices : CupOfDices
    {
        /// <summary>
        /// LargeStraight = all five dices are in sequential order 1..5 or 2..6
        /// </summary>
        public bool IsLargeStraight
        {
            get
            {
                var prevDice = this[0];
                for (int i = 1; i < Count; i++)
                {
                    if (this[i] == prevDice + 1)
                        prevDice = this[i];
                    else
                        return false;
                }
                return true;
            }
        }

        /// <summary>
        /// Yahtzee = all five dices have the same FaceValue
        /// </summary>
        public bool IsYahtzee
        {
            get
            {
                var firstDice = this[0];
                for (int i = 1; i < Count; i++)
                {
                    if (this[i] != firstDice)
                        return false;
                }
                return true;
            }
        }

        /// <summary>
        /// Chance = sum of all five dices
        /// </summary>
        public int Chance
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < Count; i++)
                {
                    sum += (int) this[i];
                }

                return sum;
            }
        }
        public YahtzeeDices() : base(5) { }
    }
}
