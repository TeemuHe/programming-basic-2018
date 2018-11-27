using System;

namespace StringTaskID
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tarkastaa henkilötunnuksen oikeellisuuden.");
            //Console.Write("Syötä henkilötunnus: ");
            //string checkMark = "0123456789ABCDEFHJKLMNPRSTUVWXY";
            //string hetuNumber = Console.ReadLine().Remove(10, 1).Remove(6, 1);

            //Console.WriteLine($"{hetuNumber} Tulostetaan tarkaste: {checkMark[hetuCheck]}");

            DateChecker();
            //LastChar();
        }
        static void DateChecker()
        {
            string hetu = "131052-308T";

            int day = int.Parse(hetu.Substring(0, 2));
            int month = int.Parse(hetu.Substring(2, 2));
            int year = int.Parse(hetu.Substring(4, 2));

            if(day > 31)
            {
                Console.WriteLine("Virheellinen päivämäärä!");
            }
            else if(month > 12)
            {
                Console.WriteLine("Virheellinen kuukausi!");
            }
            else if(day > 28 && month == 02)
            {
                Console.WriteLine("Virheellinen päivämäärä!");
            }
            else if(day > 30 && month == 04)
            {
                Console.WriteLine("Virheellinen päivämäärä!");
            }
            else if (day > 30 && month == 06)
            {
                Console.WriteLine("Virheellinen päivämäärä!");
            }
            else if (day > 30 && month == 08)
            {
                Console.WriteLine("Virheellinen päivämäärä!");
            }
            else if (day > 30 && month == 10)
            {
                Console.WriteLine("Virheellinen päivämäärä!");
            }
            else if (day > 30 && month == 12)
            {
                Console.WriteLine("Virheellinen päivämäärä!");
            }
            else
            {
                Console.WriteLine("Kuukausi ja päivämäärä tosi!");
            }
        }












        /*static void LastChar()
        {
            string hetu = "131052-308T";

            string checkMark = "0123456789ABCDEFHJKLMNPRSTUVWXY";
            try
            {
                DateTime d = new DateTime(1952, 10, 13);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            int hetuCheck = 131052308 % 31;
            Console.WriteLine($"{hetu} Tulostetaan tarkaste: {checkMark[hetuCheck]}");
        }*/

       


        
    }
}
