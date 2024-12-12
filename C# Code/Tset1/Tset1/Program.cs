// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using static System.Console;
using Tset1;

class Program
{
    static void Main()
    {
        Course course = new Course(
            "COMP123",
            "编程 II",
            "这门课程覆盖C#中面向对象中的高级部分，包括类与对象的继承关系，Files and Streams, Controls and so on.",
            "编程I",
            2
            );

        WriteLine(course);

        CourseManager.Loadcourses("courses.txt");
        WriteLine("\nAll courses"); 
        CourseManager.Display();

        Console.WriteLine("请输入要搜索的课程代码:");
        string code = Console.ReadLine();
        CourseManager.Search(code);
    }
}