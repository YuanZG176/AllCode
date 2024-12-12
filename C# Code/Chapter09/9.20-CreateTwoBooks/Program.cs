// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using _9._20_CreateTwoBooks;
using static System.Console;

class CreateTwoBooks
{
    static void Main()
    {
        Book myBook = new Book();
        Book yourBook = new Book();
        myBook.Title = "Silis Milas";
        yourBook.Title = "The Time Travel's Life";
        myBook.AdvertisingMessage();
        yourBook.AdvertisingMessage();
    }
}
