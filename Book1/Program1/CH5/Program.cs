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

            // Calculate the interest paid and the ending balance
            decimal interestPaid = principal * (rate / 100);
            decimal endingBalance = principal + interestPaid;

            Console.WriteLine("Principal      :{0:C}", principal);
            Console.WriteLine("Interest Rate  :{0}%", rate);
            Console.WriteLine();
            Console.WriteLine("Interest Paid  :{0:C}", interestPaid);
            Console.WriteLine("Ending Balance :{0:C}", endingBalance);

            // Wait for user to acknowledge the results
            Console.WriteLine("Press any key to terminate...");
            Console.Read();
        }
        
    }
}
