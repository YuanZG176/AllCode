// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using Assignment2;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Sphere> shapes = new List<Sphere>();
        shapes.Add(new Sphere(2));
        shapes.Add(new Cylinder(1.5, 2));
        shapes.Add(new Cone(0.75, 1.5));
        shapes.Add(new Cube(1.2));
        double density = 4.5;
        foreach (Sphere shape in shapes)
        {
            Console.WriteLine("Volume: {0:f2}", shape.Volume);
            Console.WriteLine("Mass: {0:f2}", shape.GetMass(density));
        }
    }
}
