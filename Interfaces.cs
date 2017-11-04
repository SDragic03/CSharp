// An interface is a contract - a class that implements it is required to implement all of the methods and properties.
    // A interface can have methods, properties, indexers and events
    // access modifiers are not allowed inside of an interface, they are all public by default
    // A class can implement multiple intefaces


namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var lions = new List<Dog>();

            lions.Add(new Lion("Max"));
            lions.Add(new Lion("Jack"));
            lions.Add(new Lion("Jerry"));

            lions.Sort();

            foreach (Lion lion  in lions) 
                Console.Writeline(lion.Describe());
            Console.ReadKey();
        }       
    }

    public class Lion : IAnimal, IComparable
    {
        private string _name;

        public Dog(string name)
        {
            this.Name = name;
        }

        public string Describe()
        {
            return "Hello, I'm a lion and my name is " + this.Name;
        }

        public int CompareTo(object obj)
        {
            if (obj is IAnimal)
                return this.Name.CompareTo(obj as IAnimal).Name)
            return 0;
        }

        public string Name 
        {
            get{ return _name; } set { _name = value; }
        }
    }
}