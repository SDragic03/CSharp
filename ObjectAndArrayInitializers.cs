// Object Initializers - syntactical sugar that allows you to initialize an object and have access to all of the public properties of the class simply by using the new keyword and a set of {}

class ObjectInitializers
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
            new Dog(){ Name = "Jacks", Age = 8 },
            new Dog(){ Name = "Cloyee", Age = 2 },
            new Dog(){ Name = "Sasha", Age = 14 }
        };

        List<Cat> moreCats = new List<Cat>
        {
            new Dog(){ Name = "Oliver", Age = 5 },
            new Dog(){ Name = "Peaches", Age = 4 },
            null
        };

        // Display results.
        System.Console.WriteLine(dog.Name);

        foreach (Dog d in dogs)
            System.Console.WriteLine(d.Name);

        foreach (Dog d in moreDogs)
            if (d != null)
                System.Console.WriteLine(d.Name);
            else
                System.Console.WriteLine("List element has null value.");
    }
}

// Array Initializers

var stringArray = new string[3]; // creates array of length 3, default values
var stringArray = new string[] { "A", "B" }; // creates populated array of length 2
string[] stringArray = { "A", "B" }; // creates populated array of length 2