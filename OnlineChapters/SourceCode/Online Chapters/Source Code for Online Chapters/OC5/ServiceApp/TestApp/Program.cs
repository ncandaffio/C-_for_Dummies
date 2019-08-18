using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the service client.
            UseTheService.TheServiceSoapClient Client = 
                new UseTheService.TheServiceSoapClient();

            // Get the input values.
            Console.Write("Type a Value1 input: ");
            int Value1 = Int32.Parse(Console.ReadLine());
            Console.Write("Type a Value2 input: ");
            int Value2 = Int32.Parse(Console.ReadLine());

            // Perform the computation and provide output.
            Console.WriteLine(Client.DoAdd(Value1, Value2));
        }
    }
}
