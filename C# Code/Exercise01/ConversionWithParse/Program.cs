// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using static System.Console;

class ConversionWithParse
{
    static void Main()
    {
        string entryString;
        int score;
        Write("ENter your test score >> ");
        entryString = ReadLine();
        score = int.Parse(entryString);
        WriteLine("you entered {0}", score);
    }
}
