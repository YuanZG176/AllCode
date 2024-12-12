using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnException
{
    internal class NagitiveBalanceException : Exception
    {
        private static string msg = "Balance cannot be nagative!";
        public NagitiveBalanceException() : base(msg)
        {

        }
    }
}
