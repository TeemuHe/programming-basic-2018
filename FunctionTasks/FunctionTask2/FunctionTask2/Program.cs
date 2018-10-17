using System;

namespace FunctionTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma palauttaa kahdesta annetusta luvusta pienemmän.");
            Console.Write("Syötä luku: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("Syötä toinen luku: ");
            int number2 = int.Parse(Console.ReadLine());
            Compare(number1, number2);
        }
        public static void Compare(int number1, int number2)
        {
            if (number1 < number2)
            {
                Console.WriteLine($"Luku {number1} on pienempi kuin luku {number2}.");
            }
            else
            {
                Console.WriteLine($"Luku {number2} on pienempi kuin luku {number1}.");
            }
        }

    }
}
