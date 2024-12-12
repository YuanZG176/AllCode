// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using _9._37_AddBooks;
using static System.Console;
class AddBooks
{
    static void Main()
    {
        Book book1 = new Book("SIlain mARN", 350, 15.65);
        Book book2 = new Book("mODFUFJ DUDI", 250, 16.00);
        Book book3;
        book3 = book1 + book2;
        WriteLine("The new books is \"{0}\"",book3.Title);
        WriteLine("It has {0} pages and cost {1}",book3.NumPages,book3.Price.ToString("C"));

    }
}