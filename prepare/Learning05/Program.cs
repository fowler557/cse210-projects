using System;

class Program
{
    static void Main(string[] args)
    {

        Rectangle rectangle = new Rectangle("red", 4, 5);
        Circle circle = new Circle("blue", 6);
        Square square = new Square("green", 3);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(rectangle);
        shapes.Add(circle);
        shapes.Add(square);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();

            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}");
        }


    }
}