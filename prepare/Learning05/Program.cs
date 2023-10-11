using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
                
        Square s1 = new Square("Red", 4);
        shapes.Add(s1);

        Circle c1 = new Circle("Yellow", 4);
        shapes.Add(c1);

        Rectangle r1 = new Rectangle("Blue", 4, 5);
        shapes.Add(r1);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            
            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}