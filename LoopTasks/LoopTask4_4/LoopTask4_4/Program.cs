using System;

namespace LoopTask4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma simuloi kolikonheiton tuloksen.");
            Console.Write("Kuinka monesti kolikkoa heitetään? ");
            int counter = int.Parse(Console.ReadLine());
            int heads = 0;
            int tails = 0;
            Random rnd = new Random();
            
            for (int i = 0; i != counter; i++)
            {
                int rndNumber = rnd.Next(2);
                if (rndNumber==0)
                {
                    tails = tails + 1;
                }
                else
                {
                    heads = heads + 1;
                }

            }
            Console.WriteLine($"Rahaa heitettiin {counter} kertaa ja kruunia saatiin {heads} ja klaavojen saatiin {tails}.");
        }
    }
}
