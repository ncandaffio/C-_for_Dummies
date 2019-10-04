using System;
using TestClassLibrary;

namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DoMath math = new DoMath();

            Console.WriteLine("1 + 2 = " + math.DoAdd(1, 2));
            Console.WriteLine("5 - 4 = " + math.DoSub(5, 4));
            Console.WriteLine("2 * 4 = " + math.DoMul(2, 4));
            Console.WriteLine("10 / 2 = " + math.DoDiv(10, 2));


            //Wait for user to aknowledge the results.
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();

        }
    }
}
