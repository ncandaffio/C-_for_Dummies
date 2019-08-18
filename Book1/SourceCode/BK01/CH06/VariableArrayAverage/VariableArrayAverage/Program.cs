using System;

namespace VariableArrayAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            // First read in the number of doubles the user intends to enter.
            Console.Write("Enter the number of values to average: ");
            string numElementsInput = Console.ReadLine();
            int numElements = Convert.ToInt32(numElementsInput);
            Console.WriteLine();

            // Now declare an array of that size.
            double[] doublesArray = new double[numElements]; // Here’s the ‘N’.

            // Accumulate the values into an array.
            for (int i = 0; i < numElements; i++)
            {
                // Prompt the user for another double.
                Console.Write("enter double #" + (i + 1) + ": ");
                string val = Console.ReadLine();
                double value = Convert.ToDouble(val);
                // Add this to the array using bracket notation.
                doublesArray[i] = value;
            }

            // Accumulate 'numElements' values from
            // the array in the variable sum.
            double sum = 0;
            for (int i = 0; i < numElements; i++)
            {
                sum = sum + doublesArray[i];
            }

            // Now calculate the average.
            double average = sum / numElements;

            // Output the results in an attractive format.
            Console.WriteLine();
            Console.Write(average + " is the average of (" + doublesArray[0]);
            for (int i = 1; i < numElements; i++)
            {
                Console.Write(" + " + doublesArray[i]);
            }
            Console.WriteLine(") / " + numElements);

            // Wait for user to acknowledge the results.
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }
    }
}
