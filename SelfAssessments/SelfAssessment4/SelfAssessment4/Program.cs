using System;
using System.Collections.Generic;
namespace Self_evaluationTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa kahden luvun perusaritmeettiset laskutoimitukset.");
            Console.Write("Syötä luku: ");
            int i = int.Parse(Console.ReadLine());
            Console.Write("Syötä luku: ");
            int j = int.Parse(Console.ReadLine());

            Console.WriteLine($"{i} + {j} = {i + j:F2}");
            Console.WriteLine($"{i} - {j} = {i - j:F2}");
            Console.WriteLine($"{i} * {j} = {i * j:F2}");
            Console.WriteLine($"{i} / {j} = {i / j:F2}");
        }
    }
}