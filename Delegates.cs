// Delegates - a reference type variable that holds the reference to a method
    // The reference can be changed at runtime

// Delegates are used for implementing events and the call-back methods.

// A delegate can refer to a method, which has the same signature as that of the delegate
public delegate int MyDelegate (string s); // This delegate can be used to reference any method that has a single string parameter and returns an int type variable

// Syntax for delegate declaration
delegate <return type> <delegate-name> <parameter list>

// Once declared 

class Program
{
    Delegate void MyDelegate (string value);

    static void Main(string[] args)
    {
        // Specify delegate with lambda expression
        MyDelegate MyDelegate = v => Console.Writeline(v);

        MyDelegate.Invoke("dog");
    }
}

// https://www.dotnetperls.com/delegate