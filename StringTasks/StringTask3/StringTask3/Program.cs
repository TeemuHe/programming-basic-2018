using System;

namespace StringTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee L-kirjaimet syötetystä tekstistä.");
            Console.Write("Syötä teksti: ");
            string text = Console.ReadLine().ToUpper();
            int counter = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if(text [i] == 'L')
                {
                    counter++;
                }                
            }
            Console.WriteLine($"Syötteessä {text} on {counter} L-kirjainta.");                    
        }
    }
}
