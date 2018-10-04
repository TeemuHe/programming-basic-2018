using System;

namespace LoopTask_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa luvun kertoman.");
            

            int number = 0;    
            int i = 1;
            int fact = 1;

            //Check that number is positive
            do
            {
                Console.Write("Syötä luku: ");
                number = int.Parse(Console.ReadLine());
                //string userInput = Console.ReadLine();
                //number = int.Parse(userInput);

                if (number <= 0)
                {
                    Console.WriteLine("Virheellinen syöte!");
                }
                    


            } while (number <= 0);

            // Calculate factorial 1 * 2 * 3 * ... * n
            while(i <= number)
            {
                fact = fact * i;   //fact=*i
                i = i + 1;         //i++;
            }

            //for(i=1;i<=number;i++)
            //{
            //    fact *= i;
            //}

            Console.WriteLine($"Luvun {number} kertoma! = {fact} ");


            


        }
    }
}
