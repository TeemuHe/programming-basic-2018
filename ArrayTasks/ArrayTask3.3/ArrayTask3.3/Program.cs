using System;

namespace ArrayTask3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro();
            int[] arrT_1 = RndArray(10);
            int[] arrT_2 = RndArray(10);
            int[] arrT_3 = ComparingArray(arrT_1, arrT_2);
            PrintData(arrT_1, "arrT_1: ");
            PrintData(arrT_2, "arrT_2: ");
            PrintData(arrT_3, "arrT_3: ");
        }
        static void Intro()
        {
            Console.WriteLine("         01 02 03 04 05 06 07 08 09 10");
            Console.WriteLine("         -----------------------------");
        }

        /// <summary>
        /// Fill array with random numbers
        /// Set array length 
        /// Return filled array
        /// </summary>
        /// <param name="length"></param>
        /// <returns>integer array</returns>
        static int [] RndArray(int length)
        {
            Random rnd = new Random();
            int[] arrT = new int[length];
            for (int i = 0; i < length; i++)
            {
                arrT[i] = rnd.Next(20);
            }
            return arrT;
        }

        /// <summary>
        /// Tulostaa taulukon tiedot näytölle.
        /// arrX = array
        /// label = headline of array
        /// </summary>
        /// <param name="arrX"></param>
        /// <param name="label"></param>

        static void PrintData(int [] arrX, string label)
        {
            Console.Write($"{label} ");
            for (int i = 0; i < arrX.Length; i++)
            {
                Console.Write($"{arrX[i]:d2} ");
            }
            Console.WriteLine();
        }
        static int [] ComparingArray(int [] array1, int [] array2)
        {
            int [] arrC = new int[array1.Length];
            for (int i = 0; i < array1.Length; i++)
            {
                if(array1[i] > array2[i])
                {
                    arrC[i] = array1[i];
                }
                else
                {
                    arrC[i] = array2[i];
                }
                Console.WriteLine();
            }return arrC;
        }
    }
}
