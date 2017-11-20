// Delegates - a reference type variable that holds the reference to a method
    // The reference can be changed at runtime

// Delegates are used for implementing events and the call-back methods.

// A delegate can refer to a method, which has the same signature as that of the delegate
public delegate int MyDelegate (string s); // This delegate can be used to reference any method that has a single string parameter and returns an int type variable

// Syntax for delegate declaration
delegate <return type> <delegate-name> <parameter list>

// Once declared 

using System;

namespace code_tester
{
    public class Program
    {
        private delegate string UppercaseDelegate(string value);

        public static void Main(string[] args)
        {
            WriteOutput("dog", new UppercaseDelegate(UppercaseFirst));
            WriteOutput("dog", new UppercaseDelegate(UppercaseLast));
            WriteOutput("dog", new UppercaseDelegate(UppercaseAll));

            WriteOutput("dog", new UppercaseDelegate(x => x.ToUpper()));

            Console.ReadKey();
        }

        private static string UppercaseFirst(string input)
        {
            var buffer = input.ToCharArray();

            buffer[0] = char.ToUpper(buffer[0]);
            return new string(buffer);
        }

        private static string UppercaseLast(string input)
        {
            var buffer = input.ToCharArray();

            buffer[buffer.Length - 1] = char.ToUpper(buffer[buffer.Length - 1]);
            return new string(buffer);
        }

        private static string UppercaseAll(string input)
        {
            return input.ToUpper();
        }

        private static void WriteOutput(string input, UppercaseDelegate del)
        {
            Console.WriteLine($"Your string before: {input}");
            Console.WriteLine($"Your string after: {del(input)}");
        }
    }
}