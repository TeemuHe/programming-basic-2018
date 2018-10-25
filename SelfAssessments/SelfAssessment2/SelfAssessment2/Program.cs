using System;

namespace SelfAssessment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa syötetyn sanan niin monesti," +
                "kuinka monta kirjainta sanassa on.");
            string empty = "";
            string printout = WordLength(empty);
            int wordLength = printout.Length;
            for (int i = 0; i < wordLength; i++)
            {
                Console.WriteLine($"{i}. {printout}");
            }
        }
        static string WordLength(string userInput)
        {
            Console.Write("Kirjoita sana: ");
            userInput = Console.ReadLine();
            return userInput;
        }
    }
}
