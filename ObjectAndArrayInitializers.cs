// Object Initializers - syntactical sugar that allows you to initialize an object and have access to all of the public properties of the class simply by using the new keyword and a set of {}

using System;
using System.Collections.Generic;

namespace ObjAndArrayInit 
{
    class Program
    {
        class Dog
        {
            // Auto-implemented properties.
            public int Age { get; set; }
            public string Name { get; set; }
        }

        static void Main()
        {
            var dog = new Dog { Age = 10, Name = "Max" };
            

            var dogs = new List<Dog>
            {
                new Dog { Name = "Jacks", Age = 8 },
                new Dog { Name = "Cloyee", Age = 2 },
                new Dog { Name = "Sasha", Age = 14 }
            };

            var moreDogs = new List<Dog>
            {
                new Dog { Name = "Oliver", Age = 5 },
                new Dog { Name = "Peaches", Age = 4 },
                null
            };

            // Display results.
            Console.WriteLine(dog.Name);

            foreach (var d in dogs)
            {
                Console.WriteLine($"Dogs name: {d.Name}");
                Console.WriteLine($"Dogs age: {d.Age}");
            }

            foreach (var d in moreDogs)
                Console.WriteLine(d != null ? $"Dogs name: {d.Name}" : "List element has null value.");
        }
    }
}

// Array Initializers

var stringArray = new string[3]; // creates array of length 3, default values
var stringArray = new string[] { "A", "B" }; // creates populated array of length 2
string[] stringArray = { "A", "B" }; // creates populated array of length 2