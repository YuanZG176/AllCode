// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using static System.Console;
class DemoSalesperson3
{
    static void Main()
    {
        Employee clerk = new Employee();
        CommissionEmployee salesperson = new CommissionEmployee();
        clerk.IdNum = 234;
        salesperson.IdNum = 345;
        DisplayGreeting(clerk);
        DisplayGreeting(salesperson);
    }

    public static void DisplayGreeting(Employee emp)
    {
        WriteLine("Hi, there from #"+emp.IdNum);
        WriteLine(emp.GetGreeting());
    }
}