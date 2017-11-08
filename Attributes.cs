// A declarative tag used to give compiler instruction and other information such as comments, description, methods and classes to a program. 

// Attributes add metadata to your program.
// Metadata is information about the types defined in a program.
// All .NET assemblies contain a specified set of metadata that describes the types and type members defined in the assembly.
// You can add custom attributes to specify any additional information that is required.

// You can apply one or more attributes to entire assemblies, modules, or smaller program elements such as classes and properties.

// You can derive a custom attibute from the System.Attribute class


[System.Serializable]  
public class Class  
{  
    // Objects of this type can be serialized.  
}  

// Predefined Attributes
[Obsolete (message)]
[Conditional("DEBUG")]
[AttributeUsage]