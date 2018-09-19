using System;

namespace IfTask1
{
    // One line comment
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Ohjelma selvittää, onko annettu luku " +
                "positiivinen, " +
                "negatiivinen vai nolla.");
            Console.Write("Syötä luku: ");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);

            if (number == 0)
                Console.WriteLine($"Luku {number} on nolla!");
            else if(number < 0)
                Console.WriteLine($"Luku {number} on negatiivinen!");
            else
                Console.WriteLine($"Luku {number} on positiivinen!");

            
            
        }
    }
}
