using System;

namespace Giraffe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Harry Potter", "JK Rowling", 400); // new object

            Book book2 = new Book("Lord of the Rings", "Tolkein", 700); // new object

            book2.title = "The hobbit"; // update title

            Console.WriteLine(book2.title);

            Console.ReadLine();
        }

    }
}