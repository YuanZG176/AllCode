// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Chapter10;
using static System.Console;
class DemoEmployees
{
    static void Main()
    {
        Employee clerk = new Employee();
        CommissionEmployee salesperson = new CommissionEmployee();
        clerk.IdNum = 123;
        clerk.Salary = 30000.00;
        salesperson.IdNum = 234;
        salesperson.Salary = 20000.00;
        salesperson.CommisonRate = 0.07;
        WriteLine("\n" +clerk.GetGreeting());
        WriteLine("Clerk #{0} salary: {1} per year",clerk.IdNum,
            clerk.Salary.ToString("C"));
        WriteLine("\n" + salesperson.GetGreeting());
        WriteLine("salesperson #{0} salary: {1} per year", salesperson.IdNum,
            salesperson.Salary.ToString("C"));
        WriteLine("...plus {0} commission on all sales", salesperson.CommisonRate.
            ToString("P"));
    }
}