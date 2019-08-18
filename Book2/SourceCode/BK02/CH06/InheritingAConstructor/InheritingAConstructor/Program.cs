using System;

// InheritingAConstructor - Demonstrate that the base class
// constructor is invoked automatically.
namespace InheritingAConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating a BaseClass object");
            BaseClass bc = new BaseClass();

            Console.WriteLine("Now creating a SubClass object");
            SubClass sc = new SubClass();

            // Wait for user to acknowledge.
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }
    }

    public class BaseClass
    {
        public BaseClass()
        {
            Console.WriteLine("\tConstructing BaseClass");
        }
    }

    public class SubClass : BaseClass
    {
        public SubClass()
        {
            Console.WriteLine("\tConstructing SubClass");
        }
    }
}
