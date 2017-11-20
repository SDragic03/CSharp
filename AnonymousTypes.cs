// Anonymous Types - a type that does not have any name and is create by using the new keyword.
// An anonymous type is a temp data type that is inferred based on the data that you include in an object initializer.
// Properties of anonymous types will be read-only properties.
// The implicitly typed variable var is used to hold the reference of anonymous types

// Anonymous type can be defined using the new keyword and object initializer syntax.
// The implicitly typed variable- var, is used to hold an anonymous type.
// Anonymous type is a reference type and all the properties are read-only.
// The scope of an anonymous type is local to the method where it is defined.

using System;

namespace code_tester
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var anonymousType = new { FirstProperty = "First", SecondProperty = 2, ThirdProperty = true };
            
            Console.WriteLine(anonymousType.FirstProperty);
            Console.WriteLine(anonymousType.SecondProperty);
            Console.WriteLine(anonymousType.ThirdProperty);
            Console.ReadKey();
        }
    }
}