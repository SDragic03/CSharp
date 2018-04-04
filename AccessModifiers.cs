// All types and type members have an accessibility level,
// which controls whether they can be used from other code in your assembly or other assemblies.
// You can use the following access modifiers to specify the accessibility of a type or member when you declare it

public class Program
{
    static void Main(string[] args)
    {
        PublicAccessModifer publicModifier = new PublicAccessModifer();
        publicModifier.PublicMethod();
        
        PrivateAccessModifier privateModifier = new PrivateAccessModifier();
        // privateModifier.PrivateMethod(); - Inaccessible due to its protection level
        
        // PrivateConstructor privateConstructor = new PrivateConstructor(); - Cannot access private constructor here
        
        ProtectedAccessModifier2 protectedModifier = new ProtectedAccessModifier2();
        // Console.WriteLine(protectedModifier.Age); // -- Cannot access protected property here
    }
}

// public
// The type or member can be accessed by any other code in the same assembly or another assembly that references it.
// can be accessed by objects of the class
// can be accessed by derived classes
public class PublicAccessModifer
{
    public void PublicMethod()
    {
        Console.WriteLine("I am a public method!");
    }
}

// private
// The type or member can be accessed only by code in the same class or struct.
// cannot be accessed by object
// cannot be accessed by derived classes
class PrivateAccessModifier // default access modifier = private
{
    private void PrivateMethod()
    {
        Console.WriteLine("I am a private method!");
    }
}

// the class cannot be accessed from outside of that class
// cannot create an object of that class
    
class PrivateConstructor
{
    private PrivateConstructor()
    {
    }
}
    
// protected
// The type or member can be accessed only by code in the same class, or in a class that is derived from that class.
// Cannot be accessed by object
// can be accessed by derived classes
public class ProtectedAccessModifier
{
    protected int Age { get; set; }
}

public class ProtectedAccessModifier2 : ProtectedAccessModifier
{
    public ProtectedAccessModifier2()
    {
        Age = 25;
    }
}