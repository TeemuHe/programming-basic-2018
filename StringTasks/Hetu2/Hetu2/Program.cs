using System;

namespace Hetu2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma kysyy lukuja niin kauan, kunnes syötät kaksi samaa lukua peräkkäin.\n");
            Random rnd = new Random(); // Satunnaislukuolion määritys.
            int oldNumber = rnd.Next(); //Arvotaan satunnainen kokonaisluku maksimiarvoilla
            int newNumber = 0;
            int sumOfNumbers = 0;

            while (true) //Ikiluuppi ehdoksi
            {
                Console.Write("Anna luku: ");

                string userInput = Console.ReadLine(); // Sopiva tietotyyppi - Metodi, jolla luetaan tietoa näppäimistöltä.
                newNumber = int.Parse(userInput);
                if (newNumber == oldNumber) // Ehto, millä silmukan suoritus keskeytetään
                    return;                  // Komento, jolla silmukan suoritus keskeytetään
                else
                {
                    oldNumber = newNumber;
                    sumOfNumbers += newNumber; // Kasvatetaan summan arvoa syötetyn luvun arvolla. Tähän kohtaan haetaan lyhyttä versiota sumOfNumbers = sumOfNUmbers + newNumber
                }
            }

            Console.WriteLine($"Lukujen summa on: {sumOfNumbers}"); // Tulostetaan lukujen summa näytölle
            
        }
}
}
