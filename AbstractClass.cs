//Abstract class - a base class that cannot be instantiated, instead you have to subclass them and create an instance of your subclass.
    //- No object of this class can be instantiated but can make derivations of this
    //- Great for frameworks

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var lion = new Lion();
            Console.Writeline(lion.describe);
            Console.ReadKey();
        }
    }

    abstract class FourLeggedAnimal
    {
        public virtual string Describe()
        {
            return "This animal has four legs!";
        }
    }

    class Lion : FourLeggedAnimal
    {
        public overrride string Describe()
        {
            var result = base.Describe();
            result += " In fact, it's a lion!";
            return result;
        }
    }
}

