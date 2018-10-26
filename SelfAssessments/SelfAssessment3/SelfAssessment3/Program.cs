using System;

namespace SelfAssessment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee luvut yhteen, kunnes luku -1 syötetään." +
                "Ohjelma tulostaa syötettyjen lukujen summan.");
            int sum = 0;

            while (true)
            {
                Console.Write("Syötä luku: ");
                bool isNumber = int.TryParse(Console.ReadLine(), out int userInput);

                if (isNumber && userInput != -1)
                {
                    sum += userInput;
                }
                else if (isNumber && userInput == -1)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Virheellinen syöte!");
                }
            }
            Console.WriteLine($"Syötteiden summa on {sum}.");
        }
    }
}
