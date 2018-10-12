using System;

namespace LoopTask4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma simuloi 1000 nopanheittoa ja laskee kuinka monta kutosta saadaan.");
            Random rnd = new Random();
            int kuusi = 0;
            int noppa = 0;
            for (int i = 1; i != 1001; i++)
            {
                Console.Write($"{i}.  ");
                double x = rnd.Next(7);

                if (x < 2)
                {
                    Console.WriteLine("1");
                }

                else if (x > 1 && x < 3)
                {
                    Console.WriteLine("2");
                }

                else if (x > 2 && x < 4)
                {
                    Console.WriteLine("3");
                }

                else if (x > 3 && x < 5)
                {
                    Console.WriteLine("4");
                }

                else if (x > 4 && x < 6)
                {
                    Console.WriteLine("5");
                }

                else if (x > 5)
                {
                    Console.WriteLine("6");
                    kuusi++;
                }
            }

                Console.WriteLine($"Heitettyjen kutosten määrä on {kuusi}.");




        }

    }
}