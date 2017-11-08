// A class can be static and it can have static members(functions and fields)
//Static - A static class can't be instantiated
    //- A static class may only contain static members (functions and fields)
    //- There is only one verson of a static class!!!!

//Common use for static classes are for "Utility Helper" classes

//NonStatic - Is like a regular class
    // Nonstatic class can have both static and non static members
    // Can be instantiated but you cant use a static member on an object of the class

// Static implementation
namespace StaticVsNonStatic
{
    class Program
    {
        static void main(string[] args) 
        {
            console.writeline("the area is: " + rectangle.calculatearea(5, 4));

        }
    }

    public static class Rectangle
    {
        public static int CalculateArea(int width, int height)
        {
            return width * height;
        }
    }
}

    // Mixing static with non static members
    namespace StaticVsNonStatic
    {
        public class Rectangle
        {
            private int _width;
            private int _height;

            public Rectangle(int width, int height)
            {
                _width = width;
                _height = height;
            }

            public void OutputArea()
            {
                Console.Writeline("Area output: " Rectangle.CalculateArea(_width, _height));
            }

            public static int CalculateArea(int width, int height)
            {
                return width * height;
            }
        }
    }