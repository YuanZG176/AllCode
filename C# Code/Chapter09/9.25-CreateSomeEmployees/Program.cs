// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using _9._25_CreateSomeEmployees;
using static System.Console;
class CreateSomeEmployees
{
    static void Main()
    {
        Employee aWork = new Employee();
        Employee anotherWork = new Employee(234);
        Employee theBoss = new Employee('A');
        WriteLine("{0,4}{1,14}",aWork.IdNumber,aWork.Salary.ToString("C"));
        WriteLine("{0,4}{1,14}", anotherWork.IdNumber, anotherWork.Salary.ToString("C"));
        WriteLine("{0,4}{1,14}", theBoss.IdNumber, theBoss.Salary.ToString("C"));

    }
}