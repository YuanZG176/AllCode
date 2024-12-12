// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


class EmployeeReadonlyDemo
{
    static void Main()
    {
        Employee myAssistant = new Employee(1234);
        Employee myDriver = new Employee(2345);
        //myAssistant.IdNumber = 3456;
    }
}


class Employee
{
    private readonly int idNumber;

    public Employee(int id)
    {
        idNumber = id;
    }

    public int IdNumber
    {
        get
        {
            return idNumber;
        }
        //set
        //{
        //    idNumber = value;
        //}
    }
}