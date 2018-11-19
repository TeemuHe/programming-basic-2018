using System;

namespace StringTaskVowel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee käyttäjän syöttämästä tekstistä vokaalien määrän.");
            Console.Write("Syötä teksti: ");
            string input = Console.ReadLine().ToLower();
            int count = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u' || input[i] == 'y' || input[i] == 'ä' || input[i] == 'ö')
                {
                    count++;
                }
            }
            Console.WriteLine($"Tekstissä {input} on {count} vokaalia.");
        }
    }
}
