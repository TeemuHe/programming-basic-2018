using System;

namespace ArrayTask2Lotto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma arpoo 7 eri lukua 1...40 ja tulostaa arvotut luvut pienimmästä suurimpaan.");
            int[] lotto = new int[40];
            Random rnd = new Random();

            for (int i = 0; i < 7; i++)
            {
                int rndNro = rnd.Next(40);
                if (lotto[rndNro] == 0)
                {
                    lotto[rndNro] = 1;
                }
                else
                    i--;
            }
            Console.WriteLine("Lottorivi: ");
            for (int i = 0; i < lotto.Length; i++)
            {
                if (lotto[i] == 1)
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();
            for (int i = 0; i < 1; i++)
            {
                int extraNro = rnd.Next(40);
                if (lotto[extraNro] == 0)
                {
                    lotto[extraNro] = 2;
                }
            }

            for (int i = 0; i < 1; i++)
            {
                int rndNro = rnd.Next(40);
                if (lotto[rndNro] == 0)
                {
                    lotto[rndNro] = 1;
                }
            }
            Console.WriteLine("Lisänumero: ");
            for (int i = 0; i < lotto.Length; i++)
            {
                if (lotto[i] == 2)
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();
        }
    }
}
