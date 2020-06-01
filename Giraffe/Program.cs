using System;

namespace Giraffe
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[,] numberGrid = {
                {1, 2 },
                {3, 4 },
                {5, 6 }
            };

            Console.WriteLine(numberGrid[2, 0]);

            Console.ReadLine();
        }

    }
}