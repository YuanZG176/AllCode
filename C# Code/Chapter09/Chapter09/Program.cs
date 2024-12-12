// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using Chapter09;
using static System.Console;
class CreateEmployee
{
    static void Main()
    {
        Employee myAssistant = new Employee();
        myAssistant.WelcomeMessage();
    }
}