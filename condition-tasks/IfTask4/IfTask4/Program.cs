using System;

namespace IfTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma lajittelee 3 lukua nousevaan järjestykseen!");
            Console.Write("Syötä 1. luku: ");
            string userInput = Console.ReadLine();
            int x = int.Parse(userInput);

            Console.Write("Syötä 2. luku: ");
            userInput = Console.ReadLine();
            int y = int.Parse(userInput);

            Console.Write("Syötä 3. luku: ");
            userInput = Console.ReadLine();
            int z = int.Parse(userInput);

            if(x < y && z < x)
            {
                Console.WriteLine($"Luvut suuruusjärjestyksessä {z} - {x} - {y}");
            }
            else if(x < y && x < z && y < z)
            {
                Console.WriteLine($"Luvut suuruusjärjestyksessä {x} - {y} - {z}");
            }
            else if(x < y && x < z && z < y)
            {
                Console.WriteLine($"Luvut suuruusjärjestyksessä {x} - {z} - {y}");
            }
            else if(y < x && x < z)
            {
                Console.WriteLine($"Luvut suuruusjärjestyksessä {y} - {x} - {z}");
            }
            else if(y < x && z < x && y < z)
            {
                Console.WriteLine($"Luvut suuruusjärjestyksessä {y} - {z} - {x}");
            }
            else if(y < x && z < x && z < y)
                Console.WriteLine($"Luvut suuruusjärjestyksessä {z} - {y} - {x}");

        }
    }
}
