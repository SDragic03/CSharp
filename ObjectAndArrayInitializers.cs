// NEED TO PERSONALIZE THIS - THIS IS COPY PASTA

https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/object-and-collection-initializers

// The following code consolidates examples from the topic.
class ObjInitializers
{
    class Dog
    {
        // Auto-implemented properties.
        public int Age { get; set; }
        public string Name { get; set; }
    }

    static void Main()
    {
        Dog dog = new Dog { Age = 10, Name = "Max" };

        List<Dog> dogs = new List<Dog>
        {
            new Dog(){ Name = "Jacks", Age= 8 },
            new Dog(){ Name = "Cloyee", Age= 2 },
            new Dog(){ Name = "Sasha", Age= 14 }
        };

        List<Cat> moreCats = new List<Cat>
        {
            new Dog(){ Name = "Oliver", Age= 5 },
            new Dog(){ Name = "Peaches", Age= 4 },
            null
        };

        // Display results.
        System.Console.WriteLine(cat.Name);

        foreach (Dog d in dogs)
            System.Console.WriteLine(d.Name);

        foreach (Dog d in moreDogs)
            if (d != null)
                System.Console.WriteLine(d.Name);
            else
                System.Console.WriteLine("List element has null value.");
    }
}