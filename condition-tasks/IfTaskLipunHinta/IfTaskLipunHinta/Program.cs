using System;

namespace IfTaskLipunHinta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Ohjelma laskee maatalousnäyttelyn lipun hinnan.");
            int ticketPrice = 16;


            Console.Write("Oletko varusmies? kyllä/ei: ");
            string userInput = Console.ReadLine();

            if (userInput == "kyllä")
            {
                double discount = 0.5;
                Console.WriteLine($"Lipun hintasi on {ticketPrice - ticketPrice * discount} euroa.");
            }

            Console.Write("Oletko opiskelija? kyllä/ei: ");
            string userInput1 = Console.ReadLine();

            if (userInput1 == "kyllä")
            {
                double discount1 = 0.45;
                Console.WriteLine($"Lipun hintasi on {ticketPrice - ticketPrice * discount1} euroa.");
                Console.Write("Oletko sekä opiskelija että MTK:n jäsen? kyllä/ei: ");
                string userInput2 = Console.ReadLine();
                if (userInput2 == "kyllä")
                {
                    double discount2 = 0.6;
                    Console.WriteLine($"Lipun hintasi on {ticketPrice - ticketPrice * discount2} euroa.");

                }
            }

            Console.Write("Syötä ikäsi numeroina: ");
            userInput = Console.ReadLine();
            int i = int.Parse(userInput);
            if (i < 7)
            {
                double discount3 = 1;
                Console.WriteLine($"Lipun hintasi on {ticketPrice - ticketPrice * discount3} euroa.");
            }

            else if (i < 7 || i < 15 || 65 < i)

            {
                double discount4 = 0.5;
                Console.WriteLine($"Lipun hintasi on {ticketPrice - ticketPrice * discount4} euroa.");
            }
            else
            {
                double discount5 = 0;
                Console.WriteLine($"Lipun hintasi on {ticketPrice - ticketPrice * discount5} euroa.");
            }


            Console.Write("Oletko MTK:n jäsen? kyllä/ei: ");
            string userInput4 = Console.ReadLine();

            if (userInput4 == "kyllä")
            {
                double discount4 = 0.15;
                Console.WriteLine($"Lipun hintasi on {ticketPrice - ticketPrice * discount4} euroa.");
            }
            
        }
    }
}
