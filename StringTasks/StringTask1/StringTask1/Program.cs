using System;

namespace StringTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee merkkien määrän.");
            Console.Write("Syötä teksti: ");
            string text = Console.ReadLine();
            Console.WriteLine(text.Length);
        }
    }
}
