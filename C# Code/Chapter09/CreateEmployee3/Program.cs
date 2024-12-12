// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using static System.Console;

class CraeteEmployee3
{
    static void Main()
    {
        Employee aWork = new Employee();
        aWork.IdNumber = 3872;
        aWork.Salary = 22.11;
        WriteLine("Employee #{0} makes {1} ", aWork.IdNumber,
        aWork.Salary.ToString("C"));
    }
}
