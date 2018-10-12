using System;

namespace LoopTask4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma simuloi kolikonheiton tuloksen." +
                "\nKolikkoa heitetään 20 kertaa.");

            int heads = 0;
            int tails = 0;

            Random rnd = new Random();

            double flip;

            //Console.Write("Syötä luku, montako kertaa kolikkoa heitetään? ");
            
            for (int i = 0; i != 20; i++)
            {
                flip = rnd.NextDouble();
                if (flip > 0.5)
                {
                    heads = heads + 1;
                }
                else
                {
                    tails = tails + 1;
                }

            }
            Console.WriteLine($"\nKruunien määrä {heads} ja klaavojen määrä {tails}.");
        }
    }
}
