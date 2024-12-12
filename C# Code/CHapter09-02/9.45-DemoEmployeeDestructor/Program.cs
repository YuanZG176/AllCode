// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using _9._45_DemoEmployeeDestructor;
using static System.Console;
class DemoEmployeeDestructor
{
    static void Main()
    {
        Employee aWorker = new Employee(101);
        Employee anotherWorker = new Employee(202);
    }
}





//class Employee
//{
//    public int idNumber { get; set; }
//    public Employee(int empId)
//    {
//        IdNumber = empId;
//        WriteLine("Employee object {0} created",IdNumber);
//    }

//    ~Employee()
//    {
//        WriteLine("Employee object {0} destroyed！",IdNumber);
//    }
//}