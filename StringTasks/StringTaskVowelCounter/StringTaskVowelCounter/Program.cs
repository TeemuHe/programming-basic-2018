using System;

namespace StringTaskVowelCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma kertoo syötteessä olevien vokaalien määrän.");
            string userInput = UserInput();
        }

        static string UserInput()
        {
            Console.Write("Syötä teksti: ");
            return Console.ReadLine();
        }
    }
}
