using System;

namespace SelfAssessments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa syötetyn sanan tai lauseen" +
                "viisi kertaa.");
            Console.Write("Kirjoita sana tai lause: ");
            string userInput = Console.ReadLine();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}. {userInput}");
            }
        }
    }
}
