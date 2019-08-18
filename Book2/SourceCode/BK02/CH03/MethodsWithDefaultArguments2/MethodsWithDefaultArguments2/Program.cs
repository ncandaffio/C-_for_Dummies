using System;

// MethodsWithDefaultArguments2-– Provide optional parameters to a method
// to avoid overloading. It’s another way to do the same thing.
namespace MethodsWithDefaultArguments2
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
        //   that has the specified number of signficant digits. That argument
        //   is optional and has a default value. If you call the method
        //   without the second argument, it uses the default value.
        public static string DisplayRoundedDecimal(decimal value,
                                          int numberOfSignificantDigits = 2)
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
    }
}
