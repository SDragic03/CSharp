// Extension methods enable you to add methods to existing types (string, int, etc)

namespace ExtensionMethods
{
    public static class IntegerExtensions
    {
        public static int StringToIntConverter(this string str)
        {
            return Int32.Parse(str);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string _str = "10";

            int num = str.StringToIntConverter(); // Should be var instead of int ... DOUBLE CHECK

            Console.WriteLine($"Output: {num}");
            Console.ReadLine();
        }
    }
}