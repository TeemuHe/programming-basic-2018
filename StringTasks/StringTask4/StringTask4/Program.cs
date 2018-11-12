using System;

namespace StringTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tarkastaa, onko syötetty sana tai lause palindromi.");
            Console.Write("Syötä sana tai lause: ");
            string text = Console.ReadLine().ToUpper();
            Console.WriteLine(text);
        }
    }
}
