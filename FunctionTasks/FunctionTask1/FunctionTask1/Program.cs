using System;

namespace FunctionTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            while (true)
            {
                Console.Write("Syötä luku: ");
                n = int.Parse(Console.ReadLine());
                if (n < 0)
                {
                    Console.WriteLine("Luku ei ole sallittu.");
                }
                else
                {
                    break;
                }
            }
            string stars = getNStars(n);
            Console.WriteLine(stars);
            Console.ReadKey();
        }
        static string getNStars(int n)
        {
            string res = string.Empty;
            for (int i = 0; i < n; i++)
            {
                res += '*';
            }
            return res;
        }

    }
}
