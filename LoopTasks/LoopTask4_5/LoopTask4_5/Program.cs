using System;

namespace LoopTask4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa vakioveikkausrivin");
            Random rnd = new Random();

            for (int i = 1; i != 14; i++)
            {
                Console.Write($"{i}.  ");
                double x = rnd.Next(100);

                if(x <= 40)
                {
                    Console.WriteLine("1");
                }

                else if(x > 40 && x < 60)
                {
                    Console.WriteLine("X");
                }

                else
                {
                    Console.WriteLine("2");
                }
            }
        }
    }
}
