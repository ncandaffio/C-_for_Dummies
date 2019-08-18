using System;

namespace ParseSequenceWithSplit
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to input a sequence of numbers.
            Console.WriteLine(
                 "Input a series of numbers separated by commas:");

            // Read a line of text.
            string input = Console.ReadLine();
            Console.WriteLine();

            // Now convert the line into individual segments
            // based upon either commas or spaces.
            char[] dividers = { ',', ' ' };
            string[] segments = input.Split(dividers);

            // Convert each segment into a number.
            int sum = 0;

            foreach (string s in segments)
            {
                // Skip any empty segments.
                if (s.Length > 0)
                {
                    // Skip strings that aren't numbers.
                    if (IsAllDigits(s))
                    {
                        // Convert the string into a 32-bit int.
                        int num = 0;
                        if (Int32.TryParse(s, out num))
                        {
                            Console.WriteLine("Next number = {0}", num);
                            // Add this number into the sum.
                            sum += num;
                        }
                        // If parse fails, move on to next number.
                    }
                }
            }

            // Output the sum.
            Console.WriteLine("Sum = {0}", sum);

            // Wait for user to acknowledge the results.
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }

        // IsAllDigits -- Return true if all characters
        //   in the string are digits.
        public static bool IsAllDigits(string raw)
        {
            // First get rid of any benign characters at either end;
            // if there's nothing left, you don't have a number.
            string s = raw.Trim();  // Ignore white space on either side.
            if (s.Length == 0) return false;

            // Loop through the string.
            for (int index = 0; index < s.Length; index++)
            {
                // A nondigit indicates that the string probably isn’t a number.
                if (Char.IsDigit(s[index]) == false) return false;
            }

            // No nondigits found; it's probably okay.
            return true;
        }
    }
}
