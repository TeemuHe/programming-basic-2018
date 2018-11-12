using System;

namespace ArrayTask3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa yksiulotteisen taulukon.");
            Console.WriteLine("[X] = [arvo]");
            int[] numbers = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(20);
            }
            for (int j = 0; j < numbers.Length; j++)
            {
                Console.WriteLine($"[{j}] = {numbers[j]:D2}");
            }
        }
    }
}
