// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using static System.Console;
using System.IO;
using FindEmployee;


class Program
{
    static void Main()
    {
        const char DELIM = ',';

        const int END = 999;

        const string FILENAME = "EmployeeData.txt";
        Employee emp = new Employee();
        FileStream inFile = new FileStream(FILENAME, FileMode.Open, FileAccess.Read);
        StreamReader reader = new StreamReader(inFile);

        string recordIn;
        string[] fields;

        double minSalary;

        WriteLine("Enter the minimun salary to find or "+END+" to quit >> ");
        minSalary  =Convert.ToDouble(ReadLine());


        while (minSalary != END)
        {

            WriteLine("{0,-5}{1,-12}{2,8}", emp.EmpNum, emp.Name, emp.Salary.ToString("C"));
            
            inFile.Seek(0, SeekOrigin.Begin);
            
            recordIn = reader.ReadLine();




            while (recordIn != null)
            {
                fields = recordIn.Split(DELIM);
                emp.EmpNum = Convert.ToInt32(fields[0]);
                emp.Name = fields[1];
                emp.Salary = Convert.ToInt32(fields[2]);

                if (emp.EmpNum >= minSalary) {
                    WriteLine("{0,-5}{1,-12}{2,8}", emp.EmpNum, emp.Name, emp.Salary.ToString("C"));
                    recordIn = reader.ReadLine();
                }
                Write("\nEnter minimum salary to find or "+END+" to qiut >> ");
                minSalary  =Convert.ToDouble(ReadLine());

            }

        }

        reader.Close();
        inFile.Close();
    }
}
