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
            return Console.ReadLine().ToUpper();
        }

        static string VowelsRemove(string d)
        {
            for (int i = 0; i < d.Length; i++)
            {
                if(d[i] == 'A' || d[i] == 'E' || d[i] == 'I' || d[i] == 'O' || d[i] == 'U' || d[i] == 'Y' || d[i] == 'Ä' || d[i] == 'Ö')
                {
                    //d.Replace(d[i].ToString(), "");
                    d = d.Remove(i, 1);
                    i--;
                }
            }
        }
    }
}
