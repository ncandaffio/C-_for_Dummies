using System;

namespace CH5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Input a number. Anything less than 0 will be converted to 0");

            //string aString = Console.ReadLine();
            //int a = Int32.Parse(aString);
            //if (a < 0)

            //{
            //    a = 0;
            //}
            //Console.WriteLine("Output: {0}", a);
            //// Wait for user to acknowledge the results
            //Console.WriteLine("Press any key to terminate...");
            //Console.Read();

            // Obtain the starting principal
            Console.WriteLine("Enter the starting pricipal. (this must be positive)");
            decimal principal = new Decimal();
            decimal rate = new Decimal();
            int duration = new Int32();
            int units = 0;
            string inputUnits = "";
            for (;;)
            {
                for (; ; )
                {
                    string inputPrincipal = Console.ReadLine();
                    try
                    {
                        principal = Decimal.Parse(inputPrincipal);
                        break;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("You have not entered a number. Please try again");
                    }
                }
                if (principal < 0)
                {
                    Console.WriteLine("The principal value cannot be negative. Please try again");
                }
                else
                {
                    break;
                }
            }

            // Obtain the interest rate
            Console.WriteLine("Enter the percentage interest rate. (this must be positive)");
            for (; ; )
            {
                for (; ; )
                {
                    string inputRate = Console.ReadLine();
                    try
                    {
                        rate = Decimal.Parse(inputRate);
                        break;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("You have not entered a number. Please try again");
                    }
                }
                if (rate < 0)
                {
                    Console.WriteLine("The interest rate cannot be negative. Please try again");
                }
                else
                {
                    break;
                }
            }

            // Obtain the Duration
            Console.WriteLine("Enter the duration");
            for (; ; )
            {
                for (; ; )
                {
                    string inputDuration = Console.ReadLine();
                    try
                    {
                        duration = Int32.Parse(inputDuration);
                        break;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("You have not entered a number. Please try again");
                    }
                }
                if (rate < 0)
                {
                    Console.WriteLine("The duration cannot be negative. Please try again");
                }
                else
                {
                    break;
                }
            }

            // Obtain the Units
            Console.WriteLine("Enter the units of time (Days / Months / Years)");
                while (units == 0)
                {
                    inputUnits = Console.ReadLine();
                switch (inputUnits)
                {
                    case "Days":
                        units = 365;
                        break;
                    case "Months":
                        units = 12;
                        break;
                    case "Years":
                        units = 1;
                        break;
                    default:
                        Console.WriteLine("You have not entered a valid response. Please enter Days, Months, or Years");
                        break;
                }

            }

            // Loop through the durations and output the results
            for (int i = 0; i <= duration; i++)
            {
                decimal interestPaid = principal * (rate / 100 / units);
                principal += interestPaid;


                // Output the status to the user
                Console.WriteLine("At the end of {0} {1}, the interest paid was {2:C} and the ending balance was {3:C}", inputUnits.TrimEnd('s'), i, interestPaid, principal);
            }

            // Wait for user to acknowledge the results
            Console.WriteLine("Press any key to terminate...");
            Console.Read();
        }
        
    }
}
