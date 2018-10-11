using System;

namespace LoopTask4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int number = 1;

            Console.WriteLine("Ohjelma tulostaa 20 satunnaista kokonaislukua väliltä 0 - 50.\n" +
                "Jokaiselle tulostetulle riville tulostetaan 5 lukua pilkulla erottaen.");

            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Rivi {i} ");
                for (int j = 1; j <= 5; j++)
                {
                    number = rnd.Next(0, 51);
                    if (j == 5)
                        Console.WriteLine($"{number}");
                    else
                        Console.Write($"{number},");
                }
            }


        }
    }
}
