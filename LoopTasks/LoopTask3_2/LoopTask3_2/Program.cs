using System;

namespace LoopTask3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee N ensimmäistä lukua yhteen!");
            int number = 0;
            int i = 1;
            int sum = 1;

            //Check that number is positive

            do
            {
                Console.Write("Syötä luku: ");
                number = int.Parse(Console.ReadLine());

                if (number <= 0)
                {
                    Console.WriteLine("Virheellinen syöte!");
                }
            } while (number <= 0);

            //Calculate sum 1 + 2 + 3 + ...+ N
            while (i <= number)
            {
                sum = sum + 1;
                i = i + 1;
            }
            Console.WriteLine($"{number} ensimmäisen luvun summa = {sum}");

           
        }
    }
}
