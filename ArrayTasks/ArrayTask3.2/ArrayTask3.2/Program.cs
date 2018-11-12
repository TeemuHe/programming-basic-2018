using System;

namespace ArrayTask3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa kaksiulotteisen taulukon (10,20).");
            int widht = 10; int hight = 20;
            int[,] array = new int[widht, hight];
            Random rnd = new Random();

            for (int i = 0; i < widht; i++)
            {
                for (int j = 0; j < hight; j++)
                {
                    array[i, j] = rnd.Next(100);
                }
            }
            for (int i = 0; i < widht; i++)
            {
                for (int j = 0; j < hight; j++)
                {
                    Console.WriteLine($"[{i:d2},{j:d2}] = {array [i,j]:d2}");
                }
            }
        }
    }
}
