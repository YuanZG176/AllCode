// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using System.Security.AccessControl;
using static System.Console;

class InputMethodDemo()
{
    static void Main()
    {
        int first, second;
        InputMethod(out first,out second);
        WriteLine("After InputMethod method,frist is {0}",first);
        WriteLine("and the second is {0}", second);


    }

    private static void InputMethod(out int one,out int two)
    {
        string s1, s2;
        Write("Enter the first Integer: ");
        s1 = ReadLine();
        Write("Enter the second Integer: ");
        s2 = ReadLine();
        one = Convert.ToInt32(s1);
        two = Convert.ToInt32(s2);

    }
}
