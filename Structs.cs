// Less expensive to use a struct vs a class
// newly instantiated stucts are placed on the stack where classes are placed on the heap
// Also, with structs you are not dealing with references like classes but instead are working directly with the struct instance
// When you pass a struct to a function it is by value instead of as a reference

// All struct constructors have to take at least one parameter
// A struct cannot inherit from other classes or structs
// Classes cannot inherit from structs
// A struct can implement custom interfaces

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car("Red");
            Console.WriteLine(car.Describe());

            car = new Car("Blue");
            Console.WriteLine(car.Describe());

            Console.ReadKey();
        }
    }
    
    struct Car
    {
        private string _color;

        public Car(string color)
        {
            _color = color;
        }

        public string Describe()
        {
            return "This car is " + Color;
        }

        public string Color { get; set; }
    }
}