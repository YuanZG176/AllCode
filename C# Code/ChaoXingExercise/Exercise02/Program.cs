

class Program
{
    static void Main()
    {
        /*        string s1 = "123";
                //string s2 = "abc";
                int a = int.Parse(s1);
                //int b = int.Parse(s2);
                int c, d;
                int.TryParse(s1, out c);
                //int.TryParse(s2, out d);
                //Console.WriteLine($"{a}, {b}, {c}, {d}");
                Console.WriteLine($"{c}, {a}");*/



        try
        {
            int a = 99;
            int x = 15;// a is set to 99
            if (x > 10) throw (new Exception()); // Since x is 15, this line throws an exception
            ++a;
            Console.WriteLine(a);// This line is not executed due to the exception
        }
        catch (Exception) { }
        
    }
}

