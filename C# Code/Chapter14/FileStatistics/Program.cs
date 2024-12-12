// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using static System.Console;
using System.IO;

class Program
{
    static void Main()
    {
        string fileName;
        Write("Enter a file  name >> ");
        fileName = Console.ReadLine();
        if (File.Exists(fileName))
        {
            WriteLine("file exists");
            WriteLine("file wa created "+ File.GetCreationTime(fileName));
            WriteLine("file was last accessed "+ File.GetLastAccessTime(fileName));
            WriteLine("file was last written to "+ File.GetLastWriteTime(fileName));
        }
        else
        {
            WriteLine("file doesnot exists");
        }
    }
}