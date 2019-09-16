using System;

namespace InheritanceBankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double initial = 100;
            Console.WriteLine("Opening a new bank account. Initial deposit is {0:C}:", initial);
            BankAccount ba = new BankAccount(initial);

            double deposit = 50;
            Console.WriteLine("Depositing {0:C}", deposit);
            ba.Deposit(deposit);

            double withdraw = 25;
            Console.WriteLine("Withdrawing {0:C}", withdraw);
            ba.Withdraw(withdraw);

            ba.ToString();


            Console.WriteLine("Opening a new savings account. Initial deposit is 1000\nThe interest rate is 5%");
            SavingsAccount sa = new SavingsAccount(1000, 5);

            deposit = 700;
            Console.WriteLine("Depositing {0:C}", deposit);
            sa.Deposit(deposit);

            withdraw = 500;
            Console.WriteLine("Withdrawing {0:C}", withdraw);
            sa.Withdraw(withdraw);

            sa.ToString();

            Console.WriteLine("Accruing interest");
            sa.AccrueInterest();

            sa.ToString();


            // Wait for user to acknowledge the results
            Console.WriteLine("Press any key to terminate...");
            Console.Read();
        }
    }
}