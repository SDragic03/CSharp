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
            // Example 1:
            Console.WriteLine("The area is: " + Rectangle.CalculateArea(5, 4));

            // Example 2:
            var rectangle = new Rectangle(4, 5);
            rectangle.OutputArea();

            Console.ReadKey();
        }
    }

    // Static class example:
    public static class Rectangle
    {
        public static int CalculateArea(int width, int height)
        {
            return width * height;
        }
    }
}

    // Mixing static with non static members
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
            Console.WriteLine($"Area output: {CalculateArea(_width, _height)}");
        }

        public static int CalculateArea(int width, int height)
        {
            return width * height;
        }
    }
    
-- Static vs. Non-static
- Solidify knowledge about instance vs static. Why can’t a static method access an instance field?

--Bitwise operations
- Look at flags enums*/
    