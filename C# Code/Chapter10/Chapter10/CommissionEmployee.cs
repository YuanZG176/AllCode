﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter10
{
    internal class CommissionEmployee:Employee
    {
        private double commissionRate;
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
}