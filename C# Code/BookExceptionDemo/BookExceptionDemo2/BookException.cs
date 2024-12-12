using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal class BookException : Exception
    {
        public BookException(string title, decimal price, int pages)
            : base(string.Format("You hava an error message:\r\nFor {0},ratio is invalid....\nPrice is {1} for {2} pages.", title,
                price.ToString("C"), pages))
        {

        }
    }

