using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4_Yuan
{
    public enum DisplayOption
    {
        All,
        Code,
        Name,
        Prerequisite,
        Semester
    }
    public static class CourseManager
    {
        public static List<Course> courses = new List<Course>();
        public static void LoadCourses(string filename)
        {
            try
            {
                string[] lines = File.ReadAllLines(filename);
                foreach (var line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 5)
                    {
                        string code = parts[0].Trim();
                        string name = parts[1].Trim();
                        string description = parts[2].Trim();
                        int semester = int.Parse(parts[3].Trim());
                        string prerequisites = parts[4].Trim();
                        Course course = new Course(code, name, description, semester.ToString(), prerequisites);
                        courses.Add(course);
                    }
                    else
                    {
                        Console.WriteLine("行格式不正确: {0}", line);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("加载课程时发生错误: {0}", ex.Message);
            }
        }
        public static List<Course> Search(DisplayOption option, string toMatch = "")
        {
            var searchChars = toMatch.ToLower().ToCharArray();
            switch (option)
            {
                case DisplayOption.Code:
                    return courses.Where(course => searchChars.Any(c => course.Code.ToLower().Contains(c))).ToList();
                case DisplayOption.Name:
                    return courses.Where(course => searchChars.Any(c => course.Name.ToLower().Contains(c))).ToList();
                case DisplayOption.Semester:
                    return courses.Where(course => searchChars.Any(c => course.Semester.ToString().Contains(c))).ToList();
                case DisplayOption.Prerequisite:
                    return courses.Where(course => searchChars.Any(c => course.Prerequisite.ToLower().Contains(c))).ToList();
                default:
                    return new List<Course>();
            }
        }
        public static void SaveCourses(string filename)
        {
            //FileStream outFile = new FileStream("course_line.txt", FileMode.Append, FileAccess.Write);
            //string filePath = @".\course_line.txt";
    
            StreamWriter writer = new StreamWriter(filename);
            foreach (var course in courses)
            {
                writer.WriteLine($"{course.Code}\n" +
                    $"{course.Name}\n" +
                    $"{course.Description}\n" +
                    $"{course.Semester}\n" +
                    $"{course.Prerequisite}");
            }
            writer.Close();
        }

        public static void Update(string code, string name, string description, string semester, string prerequisite)
        {
            Course courseToUpdate = courses.FirstOrDefault(c => c.Code == code);
            if (courseToUpdate != null)
            {
                courseToUpdate.Name = name;
                courseToUpdate.Description = description;
                courseToUpdate.Semester = int.Parse(semester);
                courseToUpdate.Prerequisite = prerequisite;
            }
            else
            {
                MessageBox.Show("课程未找到。");
            }
        }

    }
}
