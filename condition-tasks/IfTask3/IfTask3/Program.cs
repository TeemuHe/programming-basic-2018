using System;

namespace IfTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma selvittää, onko numero positiivinen vai negatiivinen sekä pariton vai parillinen");
            Console.Write("Syötä numero: ");
            string userInput = Console.ReadLine();
            int number = 0;
            bool isnumber = int.TryParse(userInput, out number);

            if (isnumber)
            {
                if (number == 0)
                    Console.WriteLine($"Luku {number} on nolla!");
                if (number < 0)
                    if (number % 2 == 0)
                        Console.WriteLine($"Luku {number} on parillinen ja negatiivinen!");
                    else
                        Console.WriteLine($"Luku {number} on pariton ja negatiivinen!");
                if (number > 0)
                    if (number % 2 == 0)
                        Console.WriteLine($"Luku {number} on parillinen ja positiivinen!");
                    else
                        Console.WriteLine($"Luku {number} on pariton ja positiivinen!");
            }
            else
                Console.WriteLine("Väärä syöte!");

        }
    }
}
