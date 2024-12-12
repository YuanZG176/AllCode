// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using static System.Console;

class ConversionWithParse
{
    static void  Main()
    {
        String entryString;
        int score;
        Write("Enter your test score >> ");
        entryString = ReadLine();
        score = int.Parse(entryString);
        WriteLine("You entered {0}", score);
    }
}