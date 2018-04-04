// An interface is a contract with a public set of members
    // A interface can have methods, properties, indexers and events
    // Interfaces cannot contain implementation only declarations
    // access modifiers are not allowed inside of an interface, they are all public by default
    // A class can implement multiple interfaces

// Why Interfaces
    // Program to an abstraction rather than a concrete type =>
    // Program to an contract (interface) rather than a concrete class

    // we wanna do this because it makes our code much more resistant to change

using System;

namespace code_tester
{
        public class Program
    {
        static void Main(string[] args)
        {
            var square = new Square(5);
            var triangle = new Triangle(3, 4, 6);
            var rectangle = new Rectangle(5, 10);

            Display("Square", square.GetPerimeter(), square.GetArea());
            Display("Triangle", triangle.GetPerimeter(), triangle.GetArea());
            Display("Rectangle", rectangle.GetPerimeter(), rectangle.GetArea());
             
            Console.ReadKey();
        }

        private static void Display(string name, double perimeter, double area)
        {
            Console.WriteLine($"Hi, I am a {name}");
            Console.WriteLine($"Perimeter: {perimeter}");
            Console.WriteLine($"Area: {area}");
            Console.WriteLine("");
        }
    }
    
    public interface IPolygon
    {
        int NumberOfSides { get; set; }
        int Length { get; set; }
        int Base { get; set; }
        int Height { get; set; }
        int Width { get; set; }

        double GetPerimeter();
        double GetArea();
    }

    public class Square : IPolygon
    {
        public int NumberOfSides { get; set; }
        public int Length { get; set; }
        public int Base { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }

        public Square(int length)
        {
            NumberOfSides = 4;
            Length = length;
        }
    
        public double GetPerimeter()
        {
            return NumberOfSides * Length;
        }

        public double GetArea()
        {
            return NumberOfSides * NumberOfSides;
        }
    }

    public class Triangle : IPolygon
    {
        public int NumberOfSides { get; set; }
        public int Length { get; set; }
        public int Base { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }

        public Triangle(int length, int myBase, int height)
        {
            NumberOfSides = 3;
            Length = length;
            Base = myBase;
            Height = height;
        }
    
        public double GetPerimeter()
        {
            return NumberOfSides * Length;
        }

        public double GetArea()
        {
            return Base * Height / 2;
        }
    }

    public class Rectangle : IPolygon
    {
        public int NumberOfSides { get; set; }
        public int Length { get; set; }
        public int Base { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }

        public Rectangle(int length, int width)
        {
            Length = length;
            Width = width;
        }

        public double GetPerimeter()
        {
            return 2 * (Length + Width);
        }

        public double GetArea()
        {
            return Width * Length;
        }
    }
}

// Explicit implementation
public class ExampleClass : IFirstInterface, ISecondInterface
{
    void IFirstInterface.SampleMethod()
    {
        System.Console.WriteLine("Functionality from IFirstInterface.SampleMethod");
    }
    void ISecondInterface.SampleMethod()
    {
        System.Console.WriteLine("Functionality from ISecondInterface.SampleMethod");
    }
}
