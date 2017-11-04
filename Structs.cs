// Less expensive to use a struct vs a class
// newly instantiated stucts are placed on the stack where classes are placed on the heap
// Also, with structs you are not dealing with references like classes but instead are working directly with the struct instance
// When you pass a struct to a function it is by value instead of as a reference

//All struct constructors have to take at least one parameter
//  THERE IS MORE TO WRITE!!!!

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car;

            car = new Car("Red");
            Console.Writeline(car.Describe());

            car = new Car("Blue");
            Console.Writeline(car.Describe());

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

        public string color
        {
            get { return _color; }
            set { _color = value }
        }
    }
}