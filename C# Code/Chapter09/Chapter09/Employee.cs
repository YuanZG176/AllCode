using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Chapter09
{
    internal class Employee
    {
        private int idNumber;
        public void WelcomeMessage()
        {
            WriteLine("Welcome from employee  #{0}",idNumber);
            WriteLine("How can I help you?");
        }
    }
}
