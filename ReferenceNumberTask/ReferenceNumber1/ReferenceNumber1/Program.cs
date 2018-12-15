using System;
using System.IO;

namespace ReferenceNumber1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                string choise = null;
                string path = @"C:\TEMP\referencenumber.txt";
                string msg = "";
                do
                {
                    choise = UserInterface();

                    switch (choise.ToUpper())
                    {
                        case "K":
                            RefNumberTest(path);
                            msg = "\nViitenumero tarkastettu! \nPaina Enter jatkaaksesi!";
                            break;
                        case "L":
                            CreateRef(path);
                            msg = "\nTiedoston loppuun kirjoitus on päättynyt! \nPaina Enter jatkaaksesi!";
                            break;
                        case "N":
                            CreateRefs(path);
                            msg = "\nTiedoston lukeminen on päättynyt! \nPaina Enter jatkaaksesi!";
                            break;
                        case "S":
                            ShowFile(path);
                            msg = "\nTiedoston lukeminen on päättynyt! \nPaina Enter jatkaaksesi!";
                            break;
                        case "X":
                            msg = "\nOhjelman suoritus päättyy!";
                            break;
                        default:
                            msg = "Nyt tuli huti yritä uudestaan - Paina Enter ja aloita alusta!";
                            break;
                    }

                    Console.WriteLine(msg);
                    Console.ReadLine();
                    Console.Clear();
                }
                while (choise.ToUpper() != "X");

            }
        }
        static string UserInterface()
        {
            Console.WriteLine("Tiedoston käsittely esimerkki!");
            Console.WriteLine("[K] Tarkastaa viitenumeron oikeellisuuden");
            Console.WriteLine("[L] Luodaan yksi viitenumero");
            Console.WriteLine("[N] Luodaan haluttu määrä viitenumeroita");
            Console.WriteLine("[S] Näytä luodut viitenumerot");
            Console.WriteLine("[X] Lopeta ohjelmansuoritus");
            Console.WriteLine();
            Console.Write("Valitse mitä tehdään: ");

            return Console.ReadLine();
        }
        static void RefNumberTest(string filePath)
        {
            string refNumberFull = Intro();
            bool isReal = Length(refNumberFull);
            int[] factory = new int[] { 7, 3, 1 };
            string refNumber = NoCheckNumber(refNumberFull);
            int checkNumber = LastNumber(refNumberFull, factory);
            LastNbrCheck(refNumber, checkNumber.ToString());
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
        static bool Length(string refNumberFull)
        {
            if(refNumberFull.Length > 3 && refNumberFull.Length < 19)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Virheellisen pituinen viitenumero!");
                return false;
            }
        }
        /// <summary>
        /// Luodaan numerosarja ilman tarkastusnumeroa
        /// </summary>
        /// <param name="refNumber"></param>
        /// <returns></returns>
        static string NoCheckNumber(string refNumberFull)
        {
            string refNumber = refNumberFull.Substring(refNumberFull.Length-1);
            //Console.WriteLine($"{refNumber}vikanro");
            return refNumber;
        }
        /// <summary>
        /// Luodaan tarkastusnumero
        /// </summary>
        /// <returns></returns>
        static int LastNumber(string refNumberFull, int [] factory)
        {          
            int sum = 0;
            int j = refNumberFull.Length - 1;
            for (int i = 0; i < refNumberFull.Length; i++)
            {
                int nbr = Convert.ToInt32(refNumberFull[j].ToString());
                sum += nbr * factory[i % 3];
                j--;
            }
            int checkNumber = 10 - (sum % 10);
            //Console.WriteLine($"{checkNumber}tarknro");
            return checkNumber;
        }
        /// <summary>
        /// Tarkastetaan onko viimeinen numero sama kuin tarkastusnumero
        /// </summary>
        /// <param name="refNumber"></param>
        /// <param name="checkNumber"></param>
        static void LastNbrCheck(string refNumber, string checkNumber)
        {           
            if (refNumber == checkNumber.ToString())
            {
                Console.WriteLine("Viitenumero on oikea");
            }
            else
            {
                Console.WriteLine("Virheellinen viitenumero!");
            }
        }
    }
}
