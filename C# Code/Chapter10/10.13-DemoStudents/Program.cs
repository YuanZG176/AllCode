// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using _10._13_DemoStudents;
using static System.Console;
class DemoStudents
{
    static void Main()
    {
        Student payingStudent = new Student();
        ScholarshipStudent freeStudent = new ScholarshipStudent();
        payingStudent.Name = "Megan";
        payingStudent.Credits = 15;
        freeStudent.Name = "lUCK";
        freeStudent.Credits = 15;
        WriteLine("{0}'s tuition is {1}",payingStudent.Name,payingStudent.Tuition.ToString("C"));
        WriteLine("{0}'s tuition is {1}",freeStudent.Name,freeStudent.Tuition.ToString("C"));
    }
}