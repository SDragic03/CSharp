// Extension methods enable you to add methods to existing types (string, int, etc)

using System;

namespace Extensions
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var myString = "10";

            var num = myString.StringToIntConverter();
            
            Console.WriteLine($"Output: {num}");
            Console.ReadKey();
        }
    }

    public static class Extensions
    {
        public static int StringToIntConverter(this string str)
        {
            return int.Parse(str);
        }
    }
}