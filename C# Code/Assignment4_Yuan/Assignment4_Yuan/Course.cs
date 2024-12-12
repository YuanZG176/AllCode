using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_Yuan
{
    public class Course
    {
        public string Code { get; private set; }
        public string Description { get;  set; }
        public string Name { get;  set; }
        public string Prerequisite { get;  set; }
        public int Semester { get;  set; }

        public Course(string code, string name, string description, string semester, string prerequisites)
        {
            Code = code;
            Name = name;
            Description = description.Length > 60 ? description.Substring(0, 60) : description;
            Semester = int.Parse(semester);
            Prerequisite = prerequisites;
        }
        public override string ToString()
        {
            string disPlayDescription = Description.Length > 60 ? Description.Substring(0, 60) + "..." : Description;

            return string.Format("课程代码:{0}\n " +
                "名称:{1}\n " +
                "描述：{2}\n " +
                "学期:{3}\n " +
                "先决条件:{4}",
                Code, Name, disPlayDescription, Semester, Prerequisite);
        }
    }
}
