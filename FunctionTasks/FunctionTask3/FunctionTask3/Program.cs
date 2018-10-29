﻿using System;

namespace FunctionTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Käyttäjältä pyydetän luku, joka on väliltä 1 - 10.");
            int retNumber = numberFromRange (1, 10);
            
            Console.WriteLine($"Syöttämäsi luku {retNumber} on väliltä 1-10.");
            
        }
        static int numberFromRange(int lowerBound, int upperBound)
        {
            int allowedNumber;
            do
            {
                Console.Write("Syötä luku: ");
                bool isNumber = int.TryParse(Console.ReadLine(), out int userInput);
                if (userInput >= lowerBound && userInput <= upperBound)
                {
                    allowedNumber = userInput;
                    break;
                }
                else
                {
                    Console.WriteLine("Virheellinen syöte!");
                }
            } while (true);
            return allowedNumber;
        } 
        
    }
}
