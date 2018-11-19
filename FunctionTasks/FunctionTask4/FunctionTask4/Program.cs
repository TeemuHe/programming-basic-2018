using System;

namespace FunctionTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            int indx = 0;
            Console.WriteLine("Syötä 10 lukua.");
            Console.WriteLine($"Suurin luku {LargestNumber(ref indx)} oli {indx}. luku.");
        }

        static int LargestNumber(ref int indx)
        {
            int largestNumber = 0;
            for (int i = 0; i < 10; i++)
            {

                Console.Write($"{i + 1}.  ");
                int userNumber = int.Parse(Console.ReadLine());
                if(userNumber < 0)
                {
                    Console.WriteLine("Väärä syöte! Syötä positiivinen luku.");
                    i--;
                }
                
                if(userNumber > largestNumber)
                {
                    largestNumber = userNumber;
                    indx = i + 1;
                }
            }
            return largestNumber;
        }
    }
}
