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

        public string Color
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

namespace Fields
{
    class Program
    {
        static void Main(string[] args)
        {
            string _firstName = "Bob";
            string _lastName = "Fancis";

            Console.Writeline("Name: " + _firstName + " " + _lastName);

            Console.Writeline("Please enter a new name:");

            _firstName = Console.Readline();
            _lastName = Console.Readline();

            Console.Writeline("Your new name is: " + _firstName + " " + _lastName):
            Console.Readline(;)
        }
    }
}