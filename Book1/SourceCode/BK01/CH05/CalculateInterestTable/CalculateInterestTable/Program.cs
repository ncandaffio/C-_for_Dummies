﻿using System;

namespace CalculateInterestTable
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define a maximum interest rate.
            int maximumInterest = 50;

            // Prompt user to enter source principal.
            Console.Write("Enter principal: ");
            string principalInput = Console.ReadLine();
            decimal principal = Convert.ToDecimal(principalInput);

            // If the principal is negative . . .
            if (principal < 0)
            {
                // . . . generate an error message . . .
                Console.WriteLine("Principal cannot be negative");
            }
            else  // Go here only if principal was > 0: thus valid.
            {
                //  . . . otherwise, enter the interest rate.
                Console.Write("Enter interest: ");
                string interestInput = Console.ReadLine();
                decimal interest = Convert.ToDecimal(interestInput);

                // If the interest is negative or too large . . .
                if (interest < 0 || interest > maximumInterest)
                {
                    //  . . . generate an error message as well.
                    Console.WriteLine("Interest cannot be negative " +
                                      "or greater than " + maximumInterest);
                    interest = 0;
                }
                else  // Reach this point only if all is well.
                {
                    // Both the principal and the interest appear to be
                    // legal; finally, input the number of years.
                    Console.Write("Enter number of years: ");
                    string durationInput = Console.ReadLine();
                    int duration = Convert.ToInt32(durationInput);

                    // Verify the input.
                    Console.WriteLine();  // Skip a line.
                    Console.WriteLine("Principal     = " + principal);
                    Console.WriteLine("Interest      = " + interest + "%");
                    Console.WriteLine("Duration      = " + duration + " years");
                    Console.WriteLine();

                    // Now loop through the specified number of years.
                    int year = 1;
                    while (year <= duration)
                    {
                        // Calculate the value of the principal plus interest.
                        decimal interestPaid;
                        interestPaid = principal * (interest / 100);

                        // Now calculate the new principal by adding
                        // the interest to the previous principal amount.
                        principal = principal + interestPaid;

                        // Round off the principal to the nearest cent.
                        principal = decimal.Round(principal, 2);

                        // Output the result.
                        Console.WriteLine(year + "-" + principal);

                        // Skip over to next year.
                        year = year + 1;
                    }
                }
            }

            // Wait for user to acknowledge the results.
            Console.WriteLine("\nPress Enter to terminate . . . ");
            Console.Read();
        }
    }
}
