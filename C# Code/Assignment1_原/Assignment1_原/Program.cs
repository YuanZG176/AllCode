// See https://aka.ms/new-console-template for more information

using Assignment1_原;
using static System.Console;
using System;

class Program
{
    static void Main(string[] args)
    {
        string[] nums = new string[6];
        int[] intArray = new int[6];
        int i;
        for (i = 0; i < 6; i++)
        {
            Console.WriteLine("请输入{0}(偶数位为不能输入为0)个数字（0-2): ",i+1);
            string num = Console.ReadLine();
            intArray[i] = int.Parse(num);
        }

        Rational rational1 = new Rational(intArray[0], intArray[1]);
        Rational rational2 = new Rational(intArray[2], intArray[3]);
        Rational rational3 = new Rational();
        Rational rational4 = new Rational(intArray[4], intArray[5]); 
        

        WriteLine("Initial fractions:");
        WriteLine("rational1的初始值为: {0}", rational1);
        WriteLine("rational2的初始值为: {0}", rational2);
        WriteLine("rational3的初始值为: {0}", rational3);
        WriteLine("rational4的初始值为: {0}", rational4);
        WriteLine();

        Rational[] rationals = { rational1, rational2, rational3, rational4 };
        Array.Sort(rationals);
        WriteLine("\nSorted fractions:");
        foreach (var rational in rationals)
        {
            WriteLine(rational);
        }
        WriteLine();

        rational1.IncreaseBy(rational2);
        rational3.DecreaseBy(rational2);
        rational4.MultipleBy(rational3);

        Console.WriteLine("Fractions after operations:");
        Console.WriteLine("rational1加rational2的值为:{0}", rational1);
        Console.WriteLine("rational3减rational2的值为:{0}", rational3);
        Console.WriteLine("rational4乘rational3的值为:{0}", rational4);
    }
}