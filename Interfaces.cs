// An interface is a contract - a class that implements it is required to implement all of the methods and properties.
    // A interface can have methods, properties, indexers and events
    // access modifiers are not allowed inside of an interface, they are all public by default
    // A class can implement multiple intefaces


using System;

namespace code_tester
{
    class Program
    {
        static void Main(string[] args)
        {
            var t1 = new Transaction("001", "11/05/2017", 75000.00);
            var t2 = new Transaction("002", "11/15/2017", 550000.00);
            
            t1.ShowTransaction();
            t2.ShowTransaction();
            Console.ReadKey();
        }       
    }

    public interface ITransactions {
        // interface members
        void ShowTransaction();
        double GetAmount();
    }
   
    public class Transaction : ITransactions {
        private readonly string _id;
        private readonly string _date;
        private readonly double _amount;

        public Transaction(string id, string date, double amount) {
            _id = id;
            _date = date;
            _amount = amount;
        }
      
        public double GetAmount() {
            return _amount;
        }
      
        public void ShowTransaction() {
            Console.WriteLine($"Transaction: {_id}");
            Console.WriteLine($"Date: {_date}");
            Console.WriteLine($"Amount: {GetAmount()}");
        }
    }
}

// Explicit implementation .................................................................
    // STILL NEED

