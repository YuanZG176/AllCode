using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

    internal class CommissionEmployee:Employee
    {
        private double commissionRate;

    public CommissionEmployee()
    {
        WriteLine("CommissionEmployee constructed");
    }
    public double CommisonRate
        {
            get
            {
                return commissionRate;
            }
            set
            {
                commissionRate = value;
            }
        }
    }

