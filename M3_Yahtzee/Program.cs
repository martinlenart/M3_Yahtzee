using System;

namespace M3_Yahtzee
{
    class Program
    {
        static void Main(string[] args)
        {
            try
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
                if (!UserInput.TryReadInt32("How many dices should the cup contain", -1, 101, out int NrOfDices))
                    return;

                var cup2 = new CupOfDices(100);
                Console.WriteLine(cup2);
                Console.WriteLine(cup2[0]);
                Console.WriteLine(cup2[cup2.Count - 1]);
                Console.WriteLine(cup2.Lowest);
                Console.WriteLine(cup2.Highest);

                Console.WriteLine("\nTesting DoubleDice");
                //Test DoubleDice
                var doubleDice = new DoubleDice();
                Console.WriteLine(doubleDice);
                Console.WriteLine($"IsPair: {doubleDice.IsPair}");

                Console.WriteLine("\nTesting YahtzeeDices");
                //Test the YahtzeeDices
                var yahtzeeDices = new YahtzeeDices();
                Console.WriteLine(yahtzeeDices);
                Console.WriteLine($"IsYahtzee: {yahtzeeDices.IsYahtzee}");
                Console.WriteLine($"IsLargeStraight: {yahtzeeDices.IsLargeStraight}");
                Console.WriteLine($"Chance: {yahtzeeDices.Chance}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error throwing the dices. Error: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Thank you for playing");
            }

        }
    }
}
