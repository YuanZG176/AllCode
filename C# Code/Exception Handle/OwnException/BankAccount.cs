using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnException
{
    internal class BankAccount
    {
        private double balance;
        public int AccountNum { get; set; }
        public double Balance
        {
            get
            {
                return balance;
            }
            set
            {
                if(value < 0)
                {
                    NagitiveBalanceException n = new NagitiveBalanceException();
                    throw (n);
                }
                balance = value;
            }
        }
    }
}
