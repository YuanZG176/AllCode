// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");



using System;
using static System.Console;
class MillPerGallon
{
    static void Main()
    {
        /*        int mileDriven;
                int gallonOfGas;
                int pmg;
                try
                {
                    Write("Enter mile driven：");
                    mileDriven = Convert.ToInt32(ReadLine());
                    Write("Enter gallons of gas purchased：");
                    gallonOfGas = Convert.ToInt32(ReadLine());
                    pmg = mileDriven / gallonOfGas;
                }
                catch(Exception e)
                {
                    pmg = 0;
                    //WriteLine("The gallonOfGas your attemping is zero");
                    //WriteLine(e.ToString());
                    WriteLine(e.Message);
                    WriteLine(e.GetType());
                }
                Write("You got {0} per gallon.", pmg);
        */



        Console.WriteLine("请输入一个整数:");
        string input = Console.ReadLine();

        if (myTryParse(input, out int result))
        {
            Console.WriteLine($"转换成功: {result}");
        }
        else
        {
            Console.WriteLine("转换失败");
        }




    }


    public static bool myTryParse(string inputString, out int number)
    {
        bool successful = true;
        try
        {
            number = Convert.ToInt32(inputString);
        }
        catch(Exception e)
        {
            successful = false;
            number = 0;
            Console.WriteLine(e.Message);
        }
        return successful;
    }
}