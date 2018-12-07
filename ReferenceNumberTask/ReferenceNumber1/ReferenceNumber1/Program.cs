using System;

namespace ReferenceNumber1
{
    class Program
    {
        static void Main(string[] args)
        {
            string refNumber = Intro();
            bool isReal = Length(refNumber);
            //Console.WriteLine(Reverse(refNumber));
            int[] factory = new int[] { 7, 3, 1 };
            int checkNumber = LastNumber(refNumber, factory);
        }
        static string Intro()
        {
            Console.WriteLine("Ohjelma tarkastaa kotimaisen viitenumeron.");
            Console.Write("Syötä viitenumero: ");
            return Console.ReadLine();
        }
        /// <summary>
        /// Tarkastaa onko numerosarja oikean mittainen
        /// </summary>
        /// <param name="refNumber"></param>
        /// <returns></returns>

        static bool Length(string refNumber)
        {
            if(refNumber.Length > 4 && refNumber.Length < 20)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Virheellinen viitenumero!");
                return false;
            }
        }

        /// <summary>
        /// Kääntää numerosarjan toisinpäin
        /// </summary>
        /// <param name="refNumber"></param>
        /// <returns></returns>

        /*static string Reverse(string refNumber)
        {
            string revNumber = "";
            for (int i = refNumber.Length-1; i >= 0; i--)
            {
                revNumber += refNumber[i];
            }
            return revNumber;
        }*/
        /// <summary>
        /// Luodaan tarkastusnumero
        /// </summary>
        /// <returns></returns>
        static int LastNumber(string refNumber, int [] factory)
        {

            int sum = 0;
            int j = refNumber.Length - 1;

            for (int i = 0; i < refNumber.Length; i++)
            {
                int nbr = Convert.ToInt32(refNumber[j]);
                sum += nbr * factory[i % 3];
                j--;
            }

            int checkNumber = 10 - (sum % 10);

            return checkNumber;
        }
    }
}
