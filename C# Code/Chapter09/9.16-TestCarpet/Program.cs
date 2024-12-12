// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using _9._16_TestCarpet;
using static System.Console;

class TestCarpet
{
    static void Main()
    {
        Carpet aRug = new Carpet();
        aRug.Width = 12;
        aRug.Length = 14;
        Write("The {0} X {1} carpet", aRug.Width, aRug.Length);
        WriteLine("has a area of {0}",aRug.Area);
        WriteLine("Our motto is : {0}", Carpet.MOTTO);
    }
}