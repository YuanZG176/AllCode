// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using static System.Console;

class CreateTwoEmployees
{
    static  void Main()
    {
        Employee aworker = new Employee();
        Employee anotherWorker = new Employee();
        DisplayEmployeeData("first", aworker);
        DisplayEmployeeData("second", anotherWorker);
    }
    static void DisplayEmployeeData(string order,Employee emp)
    {
        WriteLine("\n{0} employye's message: ",order);
        emp.WelcomeMessage();
    }
}