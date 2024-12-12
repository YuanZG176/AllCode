// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using static System.Console;
public class ParameterDemo2
{
    static void Main()
    {
        int x = 4;
        WriteLine("In main x is {0}", x);
        DisplayReferenceParameter(ref x);
        WriteLine("In main x is {0}",x);
    }
    private static void DisplayReferenceParameter(ref int number)
    {
        number = 888;
        WriteLine("In method,number is {0}", number);
    }
}