using System;

// Add a reference to your class library.
using TestClass;

namespace TestApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a DoMath object.
            DoMath math = new DoMath();

            // Test the DoMath library functions.
            Console.WriteLine("6 + 2 = {0}", math.DoAdd(6, 2));
            Console.WriteLine("6 - 2 = {0}", math.DoSub(6, 2));
            Console.WriteLine("6 * 2 = {0}", math.DoMul(6, 2));
            Console.WriteLine("6 / 2 = {0}", math.DoDiv(6, 2));

            // Wait for user to acknowledge the results.
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }
    }
}
