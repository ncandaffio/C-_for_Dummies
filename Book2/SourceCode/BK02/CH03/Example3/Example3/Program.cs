using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3
{
    class Program
    {
        public static double Average(double d1, double d2)
        {
            double average = (d1 + d2) / 2;
            return average;
        }

        static void Main(string[] args)
        {
            double v1 = 1.0;
            double v2 = 3.0;
            double averageValue = Average(v1, v2);

            Console.WriteLine("The average of " + v1
                            + " and " + v2 + " is "
                            + averageValue);

            // This also works.
            Console.WriteLine("The average of " + v1
                            + " and " + v2 + " is "
                            + Average(v1, v2));

            // Wait for user to acknowledge.
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }
    }
}
