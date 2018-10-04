using System;

namespace LoopTask3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            
            int evenSum = 0;
            int oddSum = 0;

            Console.WriteLine("Ohjelma laskee parillisten ja parittomien lukujen summan!");
            Console.Write("Syötä luku: ");
            number = int.Parse(Console.ReadLine());

            if (number >= 0)
            {
                int i = 1;
                    while (i <= number)
                    {
                        
                        if (i % 2 == 0)
                        {
                            evenSum = evenSum + i;  //evenSum += i;
                        }
                        else
                        {
                            oddSum = oddSum + i;    //oddSum += i;
                        }
                        i++;                        //Yhteinen tekijä molemmissa if ja else

                    }

                        Console.WriteLine($"Parillisten summa on {evenSum}");
                        Console.WriteLine($"Parittomien summa on {oddSum}");

            }
                        


            else if (number <= 0)
            {
                int i = -1;
                    while (i >= number)
                    {
                        
                        if (i % 2 == 0)
                        {
                            evenSum = evenSum + i;  //evenSum += i;     
                        }
                        else
                        {
                            oddSum = oddSum + i;    //oddSum += i;
                        }
                        i--;                        //Yhteinen tekijä molemmissa if ja else 
                    }

                        Console.WriteLine($"Parillisten summa on {evenSum}");
                        Console.WriteLine($"Parittomien summa on {oddSum}");

                      
            }
                   
        }
    }
}
