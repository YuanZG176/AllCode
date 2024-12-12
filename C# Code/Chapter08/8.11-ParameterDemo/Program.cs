// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using static System.Console;

class ParamsDemo()
{
    static void Main()
    {
        string[] names = {"jack","tom","zhangsan" ,"lisi"};
        DisplayStrings("add1");
        DisplayStrings("add2","add3","add4");
        DisplayStrings(names);
    }

    private static void DisplayStrings(params string[] people)
    {
        foreach (string person in people)
            Write("{0}",person);
        WriteLine("\n---------------------");
    }
}