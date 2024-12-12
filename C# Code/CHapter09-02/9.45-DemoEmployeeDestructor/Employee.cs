using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _9._45_DemoEmployeeDestructor
{
    internal class Employee
    {
        public int IdNumber { get; set; }
        public Employee(int empId)
        {
            IdNumber = empId;
            WriteLine("Employee object {0} created", IdNumber);
        }

        ~Employee()
        {
            WriteLine("Employee object {0} destroyed！", IdNumber);
        }
    }
}
