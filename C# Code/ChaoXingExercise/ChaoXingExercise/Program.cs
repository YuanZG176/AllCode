class Program
{
    static void Main(string[] args)
    {
        int a = 5;
        PlusOne( a); // 使用 'ref' 关键字来修改原始变量
        Console.WriteLine(a); // 输出变量 a 的值
    }

    static void PlusOne( int a) // PlusOne 方法接收一个 int 类型的参数，并使用 'ref' 关键字
    {
        a++; // 将参数 a 的值加 1
        Console.WriteLine(a); // 输出参数 a 的值
    }
}