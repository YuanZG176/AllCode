using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._37_AddBooks
{
    internal class Book
    {
        public Book(string title,int pages,double price)
        {
            Title = title;
            NumPages = pages;
            Price = price;
        }

        public static Book operator+(Book first,Book second)
        {
            const double EXTRA = 10.00;
            string newTitle = first.Title + " and" + second.Title;
            int newPages = first.NumPages + second.NumPages;
            double newPrice;
            if (first.Price > second.Price)
            {
                newPrice = first.Price + EXTRA;
            }
            else
            {
                newPrice = second.Price + EXTRA;
            }
            return (new Book(newTitle, newPages, newPrice));

        }

        public string Title { get; set; }
        public int NumPages { get; set; }
        public double Price { get; set; }
    }
}
