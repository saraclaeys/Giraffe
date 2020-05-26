using System;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHi("Sara");

            Console.ReadLine();
        }

        static void SayHi(string name)
        {
            Console.WriteLine("Hello " + name);

        }
    }
}
