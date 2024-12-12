using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BookExceptionDemo
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public int Pages { get; set; }


        public Book(string title, string author, decimal price, int pages)
        {
            this.Title = title;
            //this.Title = title ?? throw new Exception(nameof(title));
            this.Author = author;
            //this.Author = author ?? throw new Exception(nameof(author));
            this.Price = price;
            this.Pages = pages;

            if (this.Price > pages * 0.1m)
            {
                throw new BookException(Title, Price, Pages);
            }
        }

        public override string ToString()
        {
            return string.Format("The book's information as follows:\r\n Title:{0}, Author:{1}, Price:{2}, Pages:{3}",
                Title, Author, Price.ToString("C"), Pages);
        }
    
    }

}
