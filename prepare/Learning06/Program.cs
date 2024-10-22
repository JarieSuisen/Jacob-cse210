using System;
using System.Globalization;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        // Console.WriteLine("Hello Learning06 World!");

        string squareColour = "Cyan";
        double squareSide = 2.2;

        string rectangleColour = "Magenta";
        double rectangleLength = 4.3;
        double rectangleWidth = 6.7;
        
        string circleColour = "Light Blue";
        double circleRadius = 10.9;


        List<Shape> shapes = new List<Shape>();

        Square square = new Square
        (
            squareColour, 
            "Square", 
            squareSide
        );
        // square.SetColour("Green");
        // square.SetSide(20.65);
        // square.SetName("Square");
        
        Rectangle rectangle = new Rectangle
        (
            rectangleColour,
            "Rectangle",
            rectangleLength,
            rectangleWidth
        );
        // rectangle.SetColour("Orange");
        // rectangle.SetSides(4.43, 2.33);
        // rectangle.SetName("Rectangle");
        
        Circle circle = new Circle
        (
            circleColour,
            "Circle",
            circleRadius
        );
        // circle.SetColour("Bluish White");
        // circle.SetRadius(2.46);
        // circle.SetName("Circle");




        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            string name = shape.GetName();
            double area = shape.GetArea();
            string colour = shape.GetColour();

            Console.WriteLine($"The {colour} {name}'s area is {area} units of measurement.");

            Console.WriteLine();
        }

        // Console.WriteLine("Also, my favorite colour is blue.");

        Console.WriteLine();
    }
}