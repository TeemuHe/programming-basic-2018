using System;

namespace FunctionTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Intro(out x, out y);
            Console.WriteLine(SmallerNumber(x, y));
        }

        static void Intro(out int number1, out int number2)
        {
            Console.WriteLine("Ohjelma palauttaa kahdesta annetusta luvusta pienemmän.");
            Console.Write("Syötä luku: ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("Syötä toinen luku: ");
            number2 = int.Parse(Console.ReadLine());
        }

        static string SmallerNumber(int a, int b)
        {
            if (a == b)
                return $"Luku {a} on yhtäsuuri kuin {b}.";
            else if (b < a)
                return $"Luku {b} on pienempi kuin {a}.";
            else 
                return $"Luku {a} on pienempi kuin {b}.";
        }
    }
}
