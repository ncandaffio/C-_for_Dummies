﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// MethodsWithDefaultArguments -- Provide variations of the same methods,
//    some with default arguments, by overloading the method name.
namespace MethodsWithDefaultArguments
{
    class Program
    {
        static void Main(string[] args)
        {
            // Access the member method.
            Console.WriteLine(DisplayRoundedDecimal(12.345678M, 3));

            // Wait for user to acknowledge.
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }

        // DisplayRoundedDecimal -- Convert a decimal value into a string
        //    with the specified number of signficant digits.
        public static string DisplayRoundedDecimal(decimal value,
                                          int numberOfSignificantDigits)
        {
            // First round off the number to the specified number
            // of significant digits.
            decimal roundedValue =
                           decimal.Round(value,
                                         numberOfSignificantDigits);

            // Convert that to a string.
            string s = Convert.ToString(roundedValue);
            return s;
        }

        public static string DisplayRoundedDecimal(decimal value)
        {
            // Invoke DisplayRoundedDecimal(decimal, int) specifying
            // the default number of digits.
            string s = DisplayRoundedDecimal(value, 2);
            return s;
        }
    }
}
