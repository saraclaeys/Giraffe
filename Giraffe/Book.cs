namespace Giraffe
{
    internal class Book
    {
        public string title;
        public string author;
        public int pages;

        public Book(string aTitle, string aAuthor, int aPages) // constructor method
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }
    }
}