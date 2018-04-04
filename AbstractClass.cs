//Abstract class - a base class that cannot be instantiated, instead you have to subclass them and create an instance of your subclass.
    //- No object of this class can be instantiated but can make derivations of this
    //- Great for frameworks

using System;

namespace AbstractClass
{
    public abstract class FourLeggedAnimal
    {
        public virtual string Describe()
        {
            return "This animal has four legs! ";
        }
    }

    public class Lion : FourLeggedAnimal
    {
        public override string Describe()
        {
            var result = base.Describe();
            
            result += "In fact, it is a Lion!";
            return result;
        }
    }

    public class Cheetah : FourLeggedAnimal
    {
        public override string Describe()
        {
            var result = base.Describe();
            
            result += "In fact, it is a Cheetah!";
            return result;
        }
    }

    public class Tiger : FourLeggedAnimal
    {
        public override string Describe()
        {
            var result = base.Describe();
            
            result += "In fact, it is a Tiger!";
            return result;
        }
    }
    
    public static class Program
    {
        public static void Main(string[] args)
        {
            //var FourLeggedAnimal = new FourLeggedAnimal(); // cannot create an instance of a abstract class

            var lion = new Lion();
            var cheetah = new Cheetah();
            var tiger = new Tiger();
            
            Console.WriteLine(lion.Describe());
            Console.WriteLine(cheetah.Describe());
            Console.WriteLine(tiger.Describe());
            Console.ReadKey();
        }
    }
}

/*-- Abstract class
    - Why would you use an abstract class instead of an interface?
    - Why would you use an abstract class instead of a regular class?
    */