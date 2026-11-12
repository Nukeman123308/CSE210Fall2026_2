
using System;
using System.Collections.Generic;

List<Shape> shapes = new List<Shape>();

shapes.Add(new Square("Blue", 5));
shapes.Add(new Rectangle("Red", 6, 4));
shapes.Add(new Circle("Yellow", 3));

foreach (Shape shape in shapes)
{
    Console.WriteLine($"Color: {shape.GetColor()}");
    Console.WriteLine($"Area: {shape.GetArea():F2}");
    Console.WriteLine();
}
