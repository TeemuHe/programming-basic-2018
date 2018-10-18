using System;

namespace FunctionTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberCollector();
        }
        static void NumberCollector()
        {
            Console.Write("Syötä 10 lukua: ");
            for (int i = 1; i < 11;)
            {
                if (i == 11)
                {
                    Console.WriteLine($"Syötit luvut:");
                }
            }


        }
    }
}
