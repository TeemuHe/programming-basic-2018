using System;

namespace SelfValuationTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa tähtiä.");
            int[] numbers = new int[] { 2, 5, 10, 7, 3 };

            for (int i = 0; i < numbers.Length; i++)
            {
                PrintStars(numbers[i]);
            }
        }
        /// <summary>
        /// Tulostaa tähtiä
        /// length = tähtien määrä
        /// </summary>
        /// <param name="length"></param>
        static void PrintStars(int length)
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
