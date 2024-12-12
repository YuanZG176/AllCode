using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.IO;
using System.Reflection.PortableExecutable;

namespace Tset1
{
    internal class CourseManager
    {
        private static List<Course> courses;

        public static void Display()
        {
            if (courses == null || courses.Count == 0)
            {
                WriteLine("没有可用的课程");
                return;
            }
            foreach (var course in courses)
            {
                WriteLine(course);
                WriteLine();
            }
        }

        public static void Search(string code)
        {
            if(courses ==  null)
            {
                WriteLine("没有可用的课程");
                return;
            }

            Course findCourse = courses.Find(c => c.Code.Equals(code, StringComparison.OrdinalIgnoreCase));

            if (findCourse != null) {
                WriteLine(findCourse);
            }
            else
            {
                WriteLine("找不到代码为{0}的课程",code);
            }
        }

        public static void Loadcourses(string fileName)
        {
            courses = new List<Course>();

            try
            {
                string[] lines = File.ReadAllLines(fileName);
                for (int i = 0; i < lines.Length; i += 5)
                {
                    string name = lines[i + 1];
                    string description = lines[i + 2];
                    int semester = int.Parse(lines[i + 3]);
                    string prerequisites = lines[i + 4];
                    string code = lines[i];

                    Course course = new Course(code, name, description, prerequisites, semester);
                    courses.Add(course);
                }
            }
            catch (Exception ex)
            {
                WriteLine("加载课程时发生错误: {0}", ex.Message);
            }
        }
        }
    
}
