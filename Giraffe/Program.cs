﻿using System;

namespace Giraffe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book(); // new object
            book1.title = "Harry Potter";
            book1.author = "JK Rowling";
            book1.pages = 400;

            Book book2 = new Book(); // new object
            book2.title = "Lord of the Rings";
            book2.author = "Tolkein";
            book2.pages = 700;

            Console.WriteLine(book2.author);

            Console.ReadLine();
        }

    }
}