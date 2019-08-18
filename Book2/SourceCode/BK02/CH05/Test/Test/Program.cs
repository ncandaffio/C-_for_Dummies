using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            // First create an object.
            MyObject localObject = new MyObject();
            Console.WriteLine("localObject.n is {0}", localObject.n);

            if (localObject.nextObject == null)
            {
                Console.WriteLine("localObject.nextObject is null");
            }

            // Wait for user to acknowledge the results.
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }
    }

    public class MyObject
    {
        internal int n;
        internal MyObject nextObject;
    }
}
