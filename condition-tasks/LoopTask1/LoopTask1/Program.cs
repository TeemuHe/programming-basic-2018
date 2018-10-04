using System;

namespace LoopTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa luvun kertoman.");
            Console.Write("Syötä luku, joka on min 1: ");

            string userInput = Console.ReadLine();
            int number = 0;
            bool isnumber = int.TryParse(userInput, out number);
            if (isnumber)
            {
                if (number <= 1)
                    Console.WriteLine("Väärä syöte!");


            }


        }
    }
}
