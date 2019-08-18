using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Invoking SubClass() default");
            SubClass sc1 = new SubClass();

            Console.WriteLine("\nInvoking SubClass(int)");
            SubClass sc2 = new SubClass(0);

            // Wait for user to acknowledge.
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }
    }

    public class BaseClass
    {
        public BaseClass()
        {
            Console.WriteLine("Constructing BaseClass (default)");
        }

        public BaseClass(int i)
        {
            Console.WriteLine("Constructing BaseClass (int)");
        }
    }

    public class SubClass : BaseClass
    {
        public SubClass()
        {
            Console.WriteLine("Constructing SubClass (default)");
        }

        public SubClass(int i)
        {
            Console.WriteLine("Constructing SubClass (int)");
        }
    }
}
