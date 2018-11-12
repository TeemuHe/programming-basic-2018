using System;

namespace StringTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma muuttaa e-merkit @-merkeiksi.");
            Console.Write("Syötä teksti: ");
            string text = Console.ReadLine();
            Console.WriteLine(text.Replace("e","@"));
        }
    }
}
