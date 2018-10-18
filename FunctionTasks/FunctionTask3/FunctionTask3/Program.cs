using System;

namespace FunctionTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            int nmbr;
            NumChecker(int nmbr);
        }

        private static int NumChecker(int number)
        {
            for (int i = 0; i < 1;)
            {
                Console.WriteLine("Ohjelma katsoo onko syötetty luku väliltä 1-10.");
                Console.Write("Syötä luku: ");
                i = int.Parse(Console.ReadLine());

                if (i > 1 && i < 11)
                {
                    Console.WriteLine($"Luku {i} on väliltä 1-10.");
                }
                else if (i > 10 && i < 1)
                {
                    Console.Write($"Syötä luku väliltä 1-10.");
                    i++;
                }
            }
        }
    }
}
