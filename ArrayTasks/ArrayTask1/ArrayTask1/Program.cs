﻿using System;

namespace ArrayTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma tulostaa tuotteiden nimet ja yhteishinnat näytölle.");
            decimal[] productPrice = new decimal[] { 7.96m, 72.00m, 99.90m };
            int[] productAmount = new int[] { 1, 3, 2 };
            decimal[] productTotalPrice = new decimal[3];

            for (int i = 0; i < productTotalPrice.Length; i++)
            {
                productTotalPrice[i] = productAmount[i] * productPrice[i];
                Console.WriteLine($"Tuote {i + 1}. {productTotalPrice[i]:c}");

            }
        }
    }
}
