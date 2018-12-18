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
                            msg = "\nViitenumero luotu! \nPaina Enter jatkaaksesi!";
                            break;
                        case "N":
                            CreateRefs(path);
                            msg = "\nHaluttu määrä viitenumeroita luotu! \nPaina Enter jatkaaksesi!";
                            break;
                        case "R":
                            ReadFile(path);
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
            Console.WriteLine("[R] Näytä luodut viitenumerot");
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
        /// Luodaan viitenumero ilman tarkastusnumeroa
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
        static void CreateRef(string filePath)
        {
            string refNumberCreate = Intro2();
            bool isReal = Length2(refNumberCreate);
            int[] factory = new int[] { 7, 3, 1 };
            
            int checkNumber = CheckNumberAdd(refNumberCreate, factory);
        }
        static string Intro2()
        {
            Console.WriteLine("Luo uuden kotimaisen viitenumeron.");
            Console.Write("Syötä viitenumero ilman tarkastusnumeroa: ");
            return Console.ReadLine();
        }
        /// <summary>
        /// Tarkastaa onko viitenumero sallitun pituinen
        /// </summary>
        /// <param name="refNumberCreate"></param>
        /// <returns></returns>
        static bool Length2(string refNumberCreate)
        {
            if (refNumberCreate.Length > 2 && refNumberCreate.Length < 18)
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
        /// Luo tarkastusnumeron ja liittää sen viitenumeron perään
        /// </summary>
        /// <returns></returns>
        static int CheckNumberAdd(string refNumberCreate, int[] factory)
        {
            int sum = 0;
            int j = refNumberCreate.Length - 1;
            for (int i = 0; i < refNumberCreate.Length; i++)
            {
                int nbr = Convert.ToInt32(refNumberCreate[j].ToString());
                sum += nbr * factory[i % 3];
                j--;
            }
            int checkNumber = 10 - (sum % 10);
            if (checkNumber == 10)
            {
                checkNumber = 0;
            }
            refNumberCreate += checkNumber;
            Console.WriteLine($"{refNumberCreate}");
            return checkNumber;
        }
        /// <summary>
        /// Lukee aiemmin syötetyt viitenumerot tiedostosta referencenumber.txt
        /// </summary>
        /// <param name="filePath"></param>
        static void ReadFile(string filePath)
        {
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line = null;

                    Console.WriteLine("Tiedostosta löytyy seuraavat rivit:\n");
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Tapahtui virhe: {ex.Message}");
            }           
        }
        static void CreateRefs(string filePath)
        {
            string amount = Intro3();
            string basePart = BasePart();


        }
        /// <summary>
        /// Kerrotaan kuinka monta viitenumeroa halutaan
        /// </summary>
        /// <returns></returns>
        static string Intro3()
        {
            Console.Write("Kuinka monta kotimaista viitenumeroa tulostetaan? ");
            return Console.ReadLine();
        }
        /// <summary>
        /// Tallennetaan viitenumeron alku
        /// </summary>
        /// <returns></returns>
        static string BasePart()
        {
            Console.Write("Syötä haluamasi viitenumeron alku: ");
            return Console.ReadLine();
        }
        static string AddNumbers(int amount, string basePart)
        {
            for (int i = 0; i < amount-1; i++)
            {
                basePart += amount;
                Console.WriteLine($"{basePart}");
            }
            return basePart;
        }
    }
}
