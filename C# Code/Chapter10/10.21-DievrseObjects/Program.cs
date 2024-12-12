// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using static System.Console;
using System;
class DiverseObjects
{
    static void Main()
    {
        Student payingStudent = new Student();
        ScholarshipStudent freeStudent = new ScholarshipStudent();
        Employee clerk = new Employee();
        Write("Using Student: ");
        DisplayObjectMessage(payingStudent);
        Write("Using ScholarshipStudent: ");
        DisplayObjectMessage(freeStudent);
        Write("Using Employee: ");
        DisplayObjectMessage(clerk);
    }


    public static void DisplayObjectMessage(Object o)
    {
        WriteLine("Method sucessfully called");
    }
}
