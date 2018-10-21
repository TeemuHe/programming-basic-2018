using System;

namespace FunctionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 100, b = 80;
            int c = Calculate(a, b);
            PrintData(c);
            IncrementValue(ref c);
            PrintData(c);
        }

        static void PrintData(int value)
        {
            Console.WriteLine($"Vastaus: {value:F3}");
        }

        static int Calculate(int x, int y)
        {
            return x - y;
        }

        static void IncrementValue(ref int z)
        {
            z++;
        }
    }
}