// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using static System.Console;

class BookExceptionDemo2
{
    public static void Main()
    {
        Book[] books = new Book[5];

        for (int i = 0; i < books.Length; i++)
        {
            try
            {
                Write("Enter title: ");
                string title = ReadLine();
                Write("Enter author: ");
                string author = ReadLine();
                Write("Enter price: ");
                decimal price = decimal.Parse(ReadLine());
                Write("Enter number of pages: ");
                int pages = int.Parse(ReadLine());
                WriteLine();

                books[i] = new Book(title, author, price, pages);
            }
            catch (BookException e)
            {
                WriteLine(e.Message);
                books[i].Price = books[i].Pages * 0.10m;
                WriteLine("The price to the maximum allowed price (10 cents per page)\r\nCorrected Price: {0}", books[i].Price.ToString("C"));
            }
        }

        WriteLine("\nEntered and Corrected Book Records:");
        foreach (var book in books)
        {
           WriteLine(book.ToString());
        }
    }
}
