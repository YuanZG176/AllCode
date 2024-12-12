// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using static System.Console;
using System.IO;
class WriteSomeText
{
    static void Main()
    {

/*        string currentDirectory = Directory.GetCurrentDirectory();

        string filePath = Path.Combine(currentDirectory, "SomeText.txt");

        WriteLine("File path: {0}", filePath);*/

        FileStream outFile = new FileStream("SomeText.txt", FileMode.Create, FileAccess.Write);
        StreamWriter writter = new StreamWriter(outFile);
        Write("Enter some text>> ");
        string text = ReadLine();
        writter.WriteLine(text);
        writter.Close();
        outFile.Close();
    }
}
