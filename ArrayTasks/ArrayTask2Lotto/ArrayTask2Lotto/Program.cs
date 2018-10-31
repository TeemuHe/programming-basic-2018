using System;

namespace ArrayTask2Lotto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma arpoo 7 eri lukua 1...40 ja tulostaa arvotut luvut pienimmästä suurimpaan.");
            int[] numbers = new int[7];
            Random rnd = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(40);
            }

        }
    }
}
