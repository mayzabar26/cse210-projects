using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Create List of Shapes
        List<Shape> shapes = new List<Shape>();

        //Add square, rectangle and circle
        shapes.Add(new Square(5, "Red"));
        shapes.Add(new Rectangle(4, 6, "Blue"));
        shapes.Add(new Circle(3, "Green"));

        //Iterating through the list and displaying color and area
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}");
            Console.WriteLine($"Area: {shape.GetArea()}");
            Console.WriteLine();
        }


    }
}