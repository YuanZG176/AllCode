using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManageDemo
{
   public class Employee
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Id { get; set; }
        public Employee(string name,string gender,string id)
        {
            this.Name = name;
            this.Gender = gender;
            this.Id = id;
        }


    }
}
