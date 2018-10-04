using System;

namespace Toistoharj._4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int rndNumber;

            rndNumber = rnd.Next();
            //rnd.NextDouble();

            Console.WriteLine("Ohjelma tulostaa 10 arvottua kokonaislukua ja niiden neliöjuuret.");
            Console.WriteLine("#\tRND\tSQRT");
            for (int i = 0; i < 10; i++)
            {
                rndNumber = rnd.Next(0,100);
                Console.WriteLine($"{i+1}.\t{rndNumber}\t{Math.Sqrt(rndNumber)}");
            }



            //int i = 0;
            //while (i<10)
            {
                //rndNumber = rnd.Next(0, 100);
                //Console.WriteLine($"{i + 1}.\t{rndNumber}\t{Math.Sqrt(rndNumber)}");
                //i = i + 1; //i++
            }


            //int i = 0;
            //do
            //{
            //rndNumber = rnd.Next(0, 100);
            //Console.WriteLine($"{i + 1}.\t{rndNumber}\t{Math.Sqrt(rndNumber)}");
            //i = i + 1; //i++
            //} while (i < 100);
        }

    }
}
