    // A feature that inserts values into a string. Replaces String.Format syntax, making actual formatting cleaner to read.
    // varibles are accessed directly

namespace StringInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            int _numOfCats = 10;
            int _numOfDogs = 15;
            
            // Using string interpolation syntax
            Console.Writeline($"The petshop has {_numOfCats} Cats and {_numOfDogs} Dogs");
            Console.ReadLine();

            // Array elements
            int[] _values = { 10, 20, 30 };

            Console.Writeline($"The first value is {_values[0]}");
            Console.ReadLine();

            // Expressions
              int _id = 10;

              string result = $"The result is: {id * 10}";
              Console.WriteLine(result);

            // method call
            int MultiplyByFive(int number)
            {
                return number * 5;
            }

            static void Main()
            {
                string result = $"The result is: {MultiplyByFive(5)}"
                Console.WriteLine(result);
            }
        }
    }
}