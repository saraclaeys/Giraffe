﻿using System;

namespace Giraffe
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };

            for (int i = 0; i <= luckyNumbers.Length; i++)
            {
                Console.WriteLine(luckyNumbers[i]);
            }

            Console.ReadLine();
        }
    }
}