// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using static System.Console;


//DayOfWeek payrollDay;
//payrollDay = DayOfWeek.Tuesday;
//enum DayOfWeek
//{
//    Sunday,Monday,Tuesday,Wednesday,Thursday,Friday,Saturday
//}



class ParameterDemo1
{
    static void Main()
    {
        int x = 4;
        WriteLine("In main x is {0}", x);
        DisplayValueParameter(x);
        WriteLine("In main x is {0}", x);
    }
    private static void DisplayValueParameter(int x)
    {
        x = 777;
        WriteLine("In method,x is {0}", x);
    }
}