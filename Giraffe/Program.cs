﻿using System;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHi("Sara", 29);

            Console.ReadLine();
        }

        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hello " + name + ", you are " + age);

        }
    }
}
