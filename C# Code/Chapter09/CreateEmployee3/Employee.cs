using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


    internal class Employee
    {
        private int idNumber;
        private double salary;
    //    public int IdNumber
    //{
    //    get
    //    {
    //        return idNumber;
    //    }
    //    set
    //    {
    //        idNumber = value;
    //    }
    //}

        public int IdNumber { get; set; }
        public double Salary { get; set; }

        public void WelcomeMessage()
        {
            WriteLine("Welcome from employee  #{0}",idNumber);
            WriteLine("How can I help you?");
        }
    }

