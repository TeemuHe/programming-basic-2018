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
            bool isPalindrome = true;
            for (int i = 0; i < text.Length/2; i++)
            {
                if (text[i] != text[text.Length - 1 - i])
                {
                    isPalindrome = false;
                    break;
                }
            }

            if (isPalindrome)
            {
                Console.WriteLine($"Sana {text} on palindromi");
            }
            else
                Console.WriteLine($"Sana {text} ei ole palindromi.");

        }
    }
}
