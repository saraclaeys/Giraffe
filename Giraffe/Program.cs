﻿using System;

namespace Giraffe
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int i = 1;
            while (i <= 5)
            {
                Console.WriteLine(i);
                i++;
            }

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}