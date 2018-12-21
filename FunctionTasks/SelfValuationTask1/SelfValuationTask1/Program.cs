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
                Console.WriteLine(GetStars(numbers[i]));
                //PrintStars(numbers[i]);
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
        /// <summary>
        /// Palauttaa tähtien määrän
        /// length = tähtien määrän
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        static string GetStars(int length)
        {
            string returnStars = "";
            for (int i = 0; i < length; i++)
            {
                //returnStars += "*";
                returnStars = $"{returnStars}*";
            }
            return returnStars;
        }
    }
}
