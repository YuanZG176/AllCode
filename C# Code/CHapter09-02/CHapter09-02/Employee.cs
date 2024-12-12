using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHapter09_02
{
    internal class Employee: IComparable
    {
        public int IdNumber { get; set; }
        public double Salary { get; set; }

        int IComparable.CompareTo(object o)
        {
            int returnVal;
            Employee temp = (Employee)o;
            if (this.IdNumber > temp.IdNumber)
            {
                returnVal = 1;
            }
            else
            {
                if(this.IdNumber < temp.IdNumber)
                {
                    returnVal = -1;
                }
                else
                {
                    returnVal = 0;
                }
            }
            return returnVal;
        }
    }
}
