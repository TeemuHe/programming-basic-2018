using System;

namespace StringExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma käsittelee pilkulla erotetun datan.");
            string data = "maanantai,tiistai,keskiviikko,torstai,perjantai,lauantai,sunnuntai";
            //Versio1(data);
            //Versio2(data);
            string [] tmpData = Versio3(data);
            PrintData(tmpData);
        }
        #region Versio1
        /// <summary>
        /// Funktio käsittelee merkkijonon siten, että pilkut korvataan ENTER-merkillä.
        /// d=merkkijonon data, joka on pilkulla erotettua
        /// </summary>
        /// <param name="d"></param>

        static void Versio1(string d)
        {
            string tmpData = d.Replace(',', '\n');

            Console.WriteLine(d);
            Console.WriteLine(tmpData);
        }
#endregion

        #region Versio2
        /// <summary>
        /// Funktio etsii erotinmerkin ja tulostaa erotinmerkkien välistä merkkijonon
        /// </summary>
        /// <param name=""></param

        static void Versio2(string d)
        {
            int i = 0;
            while (true)
            {
                int p = d.IndexOf(',', i);
                if (p != -1)
                {
                    Console.WriteLine(d.Substring(i, p - i));
                    i = p + 1;
                }
                else
                {
                    Console.WriteLine(d.Substring(i));
                    break;
                }
            }
        }
#endregion

        #region Versio3

        /// <summary>
        /// Funktio pilkkoo datan SPLIT-metodia hyödyntäen
        /// </summary>
        /// <param name="d"></param>
        static string[] Versio3(string d)
        {
            string[] tmpData = d.Split(',');
            return tmpData;
            /*for (int i = 0; i < tmpData.Length; i++)
            {
                Console.WriteLine(tmpData[i]);
            }*/
        }
        #endregion

        static void PrintData(string [] d)
        {
            for (int i = 0; i < d.Length; i++)
            {
                Console.WriteLine(d[i]);
            }
        }
    }
}
