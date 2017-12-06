// Properties - allow you to control the accessibility of a classes variables
    // recommended way to access variables from the outside
    // properties cant take any parameters but you are able to process the value before its returned to the assigne
    // consists of a get and set method.
        // get - should return the variable 
        // set - should assign a value to it
    // Only one method is required, (either get or set)
        // this allows you to define read only or write only properties

namespace Properties
{
    class Property
    {
        private string _color;

        public string BlueColor
        {
            get 
            {
                return _color.ToUpper();
            }
            set 
            { 
                if(value == "Blue")
                    _color = value;
                else
                {
                    Console.Writeline("This color can only be Blue!");
                }
            }
        }
    }
}

// Fields/Variables
    // A variable or field is pretty much a storage room
    // declared by: <datetype> <name>;

namespace Fields
{
    class Program
    {
        static void Main(string[] args)
        {
            var _firstName = "Bob";
            var _lastName = "Francis";

            Console.WriteLine("Name: " + _firstName + " " + _lastName);

            Console.WriteLine("Please enter a new first name:");
            _firstName = Console.ReadLine();

            Console.WriteLine("Please enter a new last name:");
            _lastName = Console.ReadLine();

            Console.WriteLine("Your new name is: " + _firstName + " " + _lastName);
            Console.ReadLine();
        }
    }
}