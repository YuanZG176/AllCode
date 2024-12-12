using System;
using static System.Console;
class Program
{
    static void Main()
    {
        Rectangle r1 = new Rectangle(4, 5);
        Rectangle r2 = new Rectangle(7);
        Rectangle r3 = new Rectangle(12, 6);
        Rectangle[] rs = {r1,r2,r3};
        Array.Sort(rs);
        foreach (Rectangle r in rs)
        {
            WriteLine(r.ToString());
        }
    }
}

//Rectangle类
public class Rectangle : IComparable<Rectangle>
{
    public int Width { get; set; }
    public int Length { get; set; }
    public int Area { get; private set; }
    public int Perimeter { get; private set; }

    public Rectangle(int width, int length)
    {
        this.Width = width;
        this.Length = length;
        CalculateArea();
        CalculatePerimeter();
    }

    public Rectangle(int size) : this(size, size)
    {
    }

    public Rectangle() : this(0, 0)
    {
    }

    private void CalculateArea()
    {
        Area = this.Width * this.Length;
    }

    private void CalculatePerimeter()
    {
        Perimeter = 2 * (this.Width + this.Length);
    }

    public override string ToString()
    {
        return string.Format("The Rectangle's information: Width={0},Length={1},Area ={2}," +
            " Perimeter = {3}",Width,Length,Area,Perimeter);
    }

    public int CompareTo(Rectangle other)
    {
        if (other == null)
        {
            return 1;
        }
        else
        {
            return this.Area.CompareTo(other.Area);
        }
    }
}
