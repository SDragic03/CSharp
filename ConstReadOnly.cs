using System;
using System.Runtime.InteropServices.ComTypes;

namespace codeTester
{
    public class ReadonlyConst
    {

        // const
        // are immutable values that do not change their values for the life of the program
        // constants can be assigned values only at the time of declaration
        // you can only the the const keyword on primative type
        // public const string MYCONST; -- constant initializer is missing
        public const string MYCONST = "good luck changing this!";

        // since const's are implicitly static,
        // constant variables have to be accessed using "Classname.VariableName"
        // var _const = new Const();
        // Console.WriteLine(_const.CONST_VALUE); // Cannot access static constant
        Console.WriteLine(Const.CONST_VALUE);
        
        public class Const
        {
            public const int CONST_VALUE = 2;
        }

        // Constants are known at compile time


        // gotcha with consts!
        // If you reference a constant from another assembly,
        // its value will be compiled right into the calling assembly.
        // That way when you update the constant in the referenced assembly it won't change in the calling assembly!

        // readonly
        // are immutable values that do not change their values for the life of the program
        //  Read only variables can be assigned values either at runtime or at the time of instance initialization via constructor

        // Read only variables have to be accessed using the "InstanceName.VariableName"
        var _readOnly = new ReadOnly();
        Console.WriteLine(_readOnly.Connection);
        // Console.WriteLine(ReadOnly.Connection); // Cannot access non-static field in static context

        // values can be computed dynamically but need to be assigned before the constructor exits.. after that it is immutable.
        public class ReadOnly
        {
            // public readonly string ConnectionString; -- will compile
            public readonly string Connection;

            public ReadOnly()
            {
                Connection = "MyConnection";
            }

            public ReadOnly(bool secondConnection)
            {
                Connection = "AnotherConnection"; }

            public void TestMethod ()
            {
                // Connection = "NewConnection";// will not compile
            }
        }
    }
}