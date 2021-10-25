using System;

namespace M3_Yahtzee
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing CupOfDices base class");
            //Test creating empty cup
            var cup1 = new CupOfDices();
            Console.WriteLine(cup1);

            //Should be exceptions
            //Console.WriteLine(cup1[0]);
            //Console.WriteLine(cup1[cup1.Count-1]);
            //Console.WriteLine(cup1.Lowest);
            //Console.WriteLine(cup1.Highest);

            //Should be exceptions
            //var cup2 = new CupOfDices(101);
            //var cup3 = new CupOfDices(-1);

            var cup4 = new CupOfDices(5);
            Console.WriteLine(cup4);
            Console.WriteLine(cup4[0]);
            Console.WriteLine(cup4[cup4.Count - 1]);
            Console.WriteLine(cup4.Lowest);
            Console.WriteLine(cup4.Highest);

            var cup5 = new CupOfDices(100);
            Console.WriteLine(cup5);
            Console.WriteLine(cup5[0]);
            Console.WriteLine(cup5[cup5.Count - 1]);
            Console.WriteLine(cup5.Lowest);
            Console.WriteLine(cup5.Highest);
        }
    }
}
