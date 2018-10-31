using System;

namespace ArrayExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma alustaa kokonaisluku taulukon (10 alkiota), johon arvotaan lukuja 0...100.");
            int[] numbers = new int[10];
            Random rnd = new Random();

            //Set value to array numbers
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(100);
            }

            //Get values from array numbers
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine("Ohjelman suoritus on päättynyt.");
        }
    }
}
