using System;

namespace FunctionTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma palauttaa tietyn määrän tähtiä.");
            Console.Write("Syötä luku: ");
            string userInput = Console.ReadLine();
            int numberOfStars;
            int.TryParse(userInput, out numberOfStars);

            if (numberOfStars < 0)
                Console.WriteLine("Virheellinen syöte!");
            else
                for (int i = 0; i < numberOfStars; i++)
                {
                    Console.Write("*");
                }
            Console.WriteLine();

        }
    }
}
