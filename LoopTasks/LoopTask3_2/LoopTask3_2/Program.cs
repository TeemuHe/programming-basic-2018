using System;

namespace LoopTask3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int i = 1;
            int sum = 0;

            Console.WriteLine("Ohjelma laskee N ensimmäistä lukua yhteen!");

            do
            {
                Console.Write("Syötä luku: ");
                number = int.Parse(Console.ReadLine());

                if (number <= 0)
                {
                    Console.WriteLine("Virheellinen syöte!");
                }
            } while (number <= 0);

            while (i <= number)
            {
                sum = sum + i;   
                i = i + 1;         
            }

            Console.WriteLine($"{number} ensimmäisen luvun summa = {sum}");

           
        }
    }
}
