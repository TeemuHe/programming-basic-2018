using System;

namespace LoopTask3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int sum = 0;

            Console.WriteLine("Ohjelma laskee N ensimmäistä lukua yhteen!");
            Console.Write("Syötä luku: ");
            number = int.Parse(Console.ReadLine());

            if(number >= 0)
            {
                int i = 1;
                while (i <= number)
                {                
                    sum = sum + i;
                    i = i + 1;
                }
                Console.WriteLine($"{number} ensimmäisen luvun summa = {sum}");
            }

            else if(number <= 0)
            {
                int i = -1;
                while (i >= number)
                {
                    sum = sum + i;
                    i = i - 1;
                }
                Console.WriteLine($"{number} ensimmäisen luvun summa = {sum}");
            }

            
        }
    }
}
