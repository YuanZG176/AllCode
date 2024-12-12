using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


    internal class Employee
    {
        private int idNumber;
        public int IdNumber
    {
        get
        {
            return idNumber;
        }
        set
        {
            idNumber = value;
        }
    }
        public void WelcomeMessage()
        {
            WriteLine("Welcome from employee  #{0}",idNumber);
            WriteLine("How can I help you?");
        }
    }

