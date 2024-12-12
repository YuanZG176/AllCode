using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem
{
    public class Student
    {
        public int Num { get; set; }
        public string Name { get; set; }

        public Student(int num, string name)
        {
            this.Num = num;
            this.Name = name;
        }
    }
}
