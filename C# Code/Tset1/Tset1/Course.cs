using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Tset1
{
    internal class Course
    {
        public string Code { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Prerequisite { get; private set; }
        public int Semester { get; private set; }

        public Course(string code, string name, string description, string prerequisite, int semester)
        {
            this.Code = code;
            this.Name = name;
            this.Description = description;
            this.Prerequisite = prerequisite;
            this.Semester = semester;
        }

        public override string ToString()
        {
            string disPlayDescription = Description.Length > 60 ? Description.Substring(0, 60) + "..." : Description;

            return string.Format("课程代码:{0}\n " +
                "名称:{1}\n " +
                "描述：{2}\n " +
                "学期:{3}\n " +
                "先决条件:{4}",
                Code,Name, disPlayDescription, Semester,Prerequisite);
        }
    }
}
