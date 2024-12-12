using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._25_CreateSomeEmployees
{
    internal class Employee
    {
        private int idNumber;
        private string name;
        
        public int IdNumber { get; set; }
        public double Salary { get; set; }

        public Employee(): this(999, 0)
        {
            //IdNumber = 999;
            //Salary = 0;
            
        }
        public Employee(int empId):this(empId,0)
        {
            //IdNumber = empId;
            //Salary = 0;
        }
        public Employee(int empId,double sal)
        {
            IdNumber = empId;
            Salary = sal;
        }
        public Employee(char code):this(111,100000)
        {
            //IdNumber = 111;
            //Salary = 100000;
        }

    }
}
