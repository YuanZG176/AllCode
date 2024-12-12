using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _9._20_CreateTwoBooks
{
    internal class Book
    {
        private string title;
        private int numPages;
        private double price;

        public string Title
        {
            get
            {
                return this.title;
            }
            set
            {
                this.title = value;
            }
        }

        public void AdvertisingMessage()
        {
            WriteLine("Buy it now: {0}",this.Title);
        }
    }
}
