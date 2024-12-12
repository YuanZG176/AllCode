// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using static System.Console;

class ConversionWithTryParse
{
    static void Main()
    {
        string entryString;
        int score;
        Write("enter your test score >> ");;
        entryString = ReadLine();
        int.TryParse(entryString, out score);
        WriteLine("Your entered {0}",score);
    }
}
