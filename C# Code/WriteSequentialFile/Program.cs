// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using static System.Console;
using System.IO;
using WriteSequentialFile;



class Program
{
    static void Main()
    {
        const int END = 999;
        const string DELIM = ",";
        const string FILENAME = "EmployData.txt";
        Employee emp = new Employee();
        FileStream outFile = new FileStream(FILENAME,FileMode.Create,FileAccess.Write);
        StreamWriter writter = new StreamWriter(outFile);
        Write("Write employee number or "+END+" to quit >> ");
        emp.EmpNum = Convert.ToInt32(ReadLine());
        while(emp.EmpNum!= END)
        {
            Write("Enter the last name >> ");
            emp.Name = ReadLine();
            Write("ENter the Salary >> ");
            emp.Salary = Convert.ToDouble(ReadLine());
            writter.WriteLine(emp.EmpNum + DELIM + emp.Name + DELIM + emp.Salary);
            Write("ENter the next employee number or "+ END + " to quit >> ");
            emp.EmpNum = Convert.ToInt32(ReadLine());
        }

        writter.Close();
        outFile.Close();
    }
}
