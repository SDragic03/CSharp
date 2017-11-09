// Anonymous Types - a type that does not have any name and is create by using the new keyword.
// An anonymous type is a temp data type that is inferred based on the data that you include in an object initializer.
// Properties of anonymous types will be read-only properties.
// The implicitly typed variable var is used to hold the reference of anonymous types

// Anonymous type can be defined using the new keyword and object initializer syntax.
// The implicitly typed variable- var, is used to hold an anonymous type.
// Anonymous type is a reference type and all the properties are read-only.
// The scope of an anonymous type is local to the method where it is defined.

namespace AnonymousType
{
    class Program
    {
        static void Main(string[] args)
        {
            var anonymousType = new {firstProperty = "First", secondProperty = 2, thirdProperty = true};

            Console.WriteLine(anonymousType.firstProperty);
            Console.ReadLine(); //Console.ReadKey();
        }
    }
}