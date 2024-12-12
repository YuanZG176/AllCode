// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using BookExceptionDemo;
using System;
using static System.Console;

class program
{
    public static void Main()
    {
        var books = new List<(string Title, string Author, decimal Price, int Pages)>
        {
            ("Goodnight Moon", "Margaret Wise Brown", 12.99m, 25),
            ("The Great Gatsby", "F. Scott Fitzgerald", 10.00m, 200),
            ("To Kill a Mockingbird", "Harper Lee", 7.99m, 100),
            ("1984", "George Orwell", 9.99m, 300),
            ("War and Peace", "Leo Tolstoy", 25.00m, 40),
            ("Moby Dick", "Herman Melville", 20.00m, 45)
        };

        foreach (var single in books)
        {
            try
            {
                var book = new Book(single.Title, single.Author, single.Price, single.Pages);
            }
            catch(BookException e)
            {
                WriteLine(e.Message);
                WriteLine();
            }
        }


/*
 * try
        {
            Book book1 = new Book("Goodnight Moon", "Margaret Wise Brown", 12.99m, 25);
            Book book2 = new Book("The Great Gatsby", "F. Scott Fitzgerald", 10.00m, 200);
            Book book3 = new Book("To Kill a Mockingbird", "Harper Lee", 7.99m, 100);
            Book book4 = new Book("1984", "George Orwell", 9.99m, 300);
            Book book5 = new Book("War and Peace", "Leo Tolstoy", 25.00m, 40); 
            Book book6 = new Book("Moby Dick", "Herman Melville", 20.00m, 45);
        }
        catch (BookException e)
        {
            WriteLine(e.Message);
        }
*/
    }
}
