using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace codeTester
{
    public class Program
    {
        static void Main(string[] args)
        {
            foreach (var i in ReturnWithoutYield())
            {
                Console.WriteLine(i);
            }

            foreach (var i in ReturnWithYield())
            {
                Console.WriteLine(i);
            }

            // will loop infinitely
            foreach (var i in LoopInfinitelyWithoutYield().Take(3))
            {
                Console.WriteLine(i);
            }

            // the method only gets called until Take() is satisfied
            foreach (var i in LoopInfinitelyWithYield().Take(3))
            {
                Console.WriteLine(i);
            }

            foreach (var i in EvenIntegers())
            {
                Console.WriteLine(i);
            }

            foreach (var i in GetRandomNumbers())
            {
                Console.WriteLine(i);
            }

            // we get 5 checks where the amount is multipled by 2
            var checks = GetChecks();

            // we pass checks to the DoubleAmounts()
            // we use the yield returned results (state machine) to double the amount of each check
            // since we do not have a reference to all of the checks we created they get discarded
            DoubleAmounts(checks);

            var amount = checks.First().Amount;
            Console.WriteLine(amount); // 2
        }

        // traditional loops
        // We have to construct a list 
        // foreach-construct has to loop over all the values in the list

        public static IEnumerable<int> ReturnWithoutYield()
        {
            var i = 0;
            var list = new List<int>();

            while (i < 5)
                list.Add(++i);
            return list;
        }

        // yield return
        // no list needed!
        // returns an IEnumerable 
        // each iteration of the foreach loop calls the iterator method
        // a value is returned when the yield return statement is reached
        // the current location in the code is retained
        // execution is restarted from that location the next time the iterator function is called

        public static IEnumerable<int> ReturnWithYield()
        {
            var i = 0;

            while (i < 5)
                yield return ++i;
        }

        // infinite loops

        // We do not need to deal with a list because we are returning a value 
        public static IEnumerable<int> LoopInfinitelyWithYield()
        {
            var i = 0;

            while (true)
                yield return ++i;
        }

        // because we are utilizing a list 
        // the loop will never finish until we get OutOfMemoryException 
        public static IEnumerable<int> LoopInfinitelyWithoutYield()
        {
            var i = 0;
            var list = new List<int>();

            while (true)
                list.Add(++i);
           // return list; // we will never get to this point
        }

        public static IEnumerable<int> EvenIntegers()
        {
            yield return 2;
            yield return 4;
            yield return 6;
            yield return 8;
            yield return 10;
        }

        static readonly Random random = new Random();
        
        // we get the next random number
        // if the number is divisable by 10
        // we utilize yield break (returning without actually returning a value),
        // to specify that the iterator needs to end
        // and we exit the loop
        // if the number is not divisable by 10,
        // we return that value to the caller, our place in the iteration is saved,
        // and we continue with the loop
        public static IEnumerable GetRandomNumbers()
        {
            while (true)
            {
                var number = random.Next();

                if (number % 10 == 0)
                    yield break;
                yield return number;
            }
        }

        // multiple iterations 

        public class Check
        {
            public int Amount { get; set; }
        }

        public static IEnumerable<Check> GetChecks()
        {
            for (var i = 1; i < 6; i++)
                yield return new Check {Amount = i * 2};
        }

        public static void DoubleAmounts(IEnumerable<Check> checks)
        {
            foreach (var check in checks)
            {
                check.Amount = check.Amount * 2;
            }
        }
    }
}