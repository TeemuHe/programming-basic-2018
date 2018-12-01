using System;

namespace Hetu
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                string hetuNumber = Intro();
                if (DateChecker(hetuNumber))
                {
                    string check = LastMark(hetuNumber);
                    bool isReal = LastChar(check, hetuNumber.Substring(10));
                    PrintData(isReal);
                    break;
                }
            } while (true);
        }
        static string Intro()
        {
            Console.WriteLine("Ohjelma tarkastaa henkilötunnuksen oikeellisuuden.");
            Console.Write("Syötä henkilötunnus: ");
            return Console.ReadLine();
        }
        static string LastMark(string hetuNumber)
        {
            string checkMark = "0123456789ABCDEFHJKLMNPRSTUVWXY";
            string strHetu = hetuNumber.Remove(6, 1);
            int hetuCheck = int.Parse(strHetu.Remove(9));
            hetuCheck = hetuCheck % 31;
            string lastChar = checkMark[hetuCheck].ToString();
            return lastChar;
        }
        static bool DateChecker(string Number)
        {
            int day = int.Parse(Number.Substring(0, 2));
            int month = int.Parse(Number.Substring(2, 2));
            int year = int.Parse(Number.Substring(4, 2));

            try
            {
                DateTime d = new DateTime(year, month, day);
            }
            catch
            {
                Console.WriteLine("Virheellinen päivämäärä");
                return false;
            }
            return true;
        }
        static bool LastChar(string letter1, string letter2)
        {
            if (letter2 == letter1)
                return true;
            else
                return false;
        }
        static void PrintData(bool data)
        {
            if (data)
            {
                Console.WriteLine("Henkilötunnus on oikea!");
            }
            else
            {
                Console.WriteLine("Väärä henkilötunnus!");
            }
        }
    }
}
