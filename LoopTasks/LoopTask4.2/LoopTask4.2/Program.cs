using System;

namespace LoopTask4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa kertotaulun luvuille 1 - 9.");
            Console.WriteLine("Aloita ohjelma painamalla jotain näppäintä.");
            Console.ReadKey();

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }
            }

            //int number1 = 1;
            //int number2 = 1;
            //int answer = 1;



            //for (number1 = 1; number1 <= 9; number1++)
            //{
              //  for (number2 = 1; number2 <= 9; number2++)
                //{
                  //  answer = number1 * number2;
                    //Console.WriteLine($"{number1} * {number2} = {answer}");
               // }
            
        }
    }
}
