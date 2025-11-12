using System;

class Program
{
    static void Main(string[] args)
    {

        List<Shape> shapes = new List<Shape>() { };

        Rectangle rectangle = new Rectangle("blue", 6, 7);
       

        Console.WriteLine($"The color of the rectangle is {rectangle.GetColor()} and it has an area of {rectangle.GetArea()}");

        Square square = new Square("red",6);
       

        Console.WriteLine($"The squares color is {square.GetColor()} and it has an area of {square.GetArea()}");

        Circle circle = new Circle("white",6);


        Console.WriteLine($"The squares color is {circle.GetColor()} and it has an area of {circle.GetArea()}");

        Console.WriteLine();

        shapes.Add(rectangle);
        shapes.Add(square);
        shapes.Add(circle);

        foreach(Shape s in shapes)
        {

            string color = s.GetColor();

            double area = s.GetArea();


            Console.WriteLine($"color: {color}\n area: {area}");

        }
    }
}