// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using static System.Console;
class CreateEmployee2
{
    static void Main()
    {
        Employee myChef = new Employee();
        myChef.IdNumber = 2345;
        WriteLine("ID number is {0}", myChef.IdNumber);
        myChef.WelcomeMessage();
    }
}