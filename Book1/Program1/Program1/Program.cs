using System;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name please:");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name);
            // Wait for user to acknowledge the results
            Console.WriteLine("Press any key to terminate...");
            Console.Read();
            
        }
    }
}
