// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using static System.Console;
class DemoObjectInitailizer
{
    static void Main()
    {
        Employee aWork = new Employee { IdNumber = 101 };
        WriteLine("Employee #{0} exists. Salary is {1}",aWork.IdNumber,aWork.Salary);
    }
}


class Employee
{
    public int IdNumber { get; set; }
    public double Salary { get; set; }
    public Employee()
    {
        Salary = 99.99;
        WriteLine("Employee #{0} created. Salary is {1}.",IdNumber,Salary);
    }

}