using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Assignment4_Yuan
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            CourseManager.LoadCourses("course.txt");

            //show all courses CourseManager.Search(DisplayOption.All);

            //search courses by Prerequsite with “COMP100” value string toSearch = "COMP100"; CourseManager.Search(DisplayOption.Prerequsite, toSearch);

            string toSearch = "Programing I"; 
            CourseManager.Search(DisplayOption.Name, toSearch);

            //search course in the second semester toSearch = "2";
            CourseManager.Search(DisplayOption.Semester, toSearch);

        }
    }
}
