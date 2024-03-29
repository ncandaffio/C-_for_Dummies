﻿using System;

// DoubleBankAccount -- Create a bank account using a double variable
//    to store the account balance (keep the balance in a private
//    variable to hide its implementation from the outside world).
namespace DoubleBankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            // Open a bank account.
            Console.WriteLine("Create a bank account object");
            BankAccount ba = new BankAccount();
            ba.InitBankAccount();

            // Make a deposit.
            double deposit = 123.454;
            Console.WriteLine("Depositing {0:C}", deposit);
            ba.Deposit(deposit);

            // Account balance
            Console.WriteLine("Account = {0}", ba.GetString());

            // Here's the problem.
            double fractionalAddition = 0.002;
            Console.WriteLine("Adding {0:C}", fractionalAddition);
            ba.Deposit(fractionalAddition);

            // Resulting balance
            Console.WriteLine("Resulting account = {0}", ba.GetString());

            // Wait for user to acknowledge the results.
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }
    }

    // BankAccount -- Define a class that represents a simple account.
    public class BankAccount
    {
        private static int _nextAccountNumber = 1000;
        private int _accountNumber;

        // Maintain the balance as a double variable.
        private double _balance;

        // Init -- Initialize a bank account with the next
        //    account id and a balance of 0.
        public void InitBankAccount()
        {
            _accountNumber = ++_nextAccountNumber;
            _balance = 0.0;
        }

        // GetBalance -- Return the current balance.
        public double GetBalance()
        {
            return _balance;
        }

        // AccountNumber
        public int GetAccountNumber()
        {
            return _accountNumber;
        }

        public void SetAccountNumber(int accountNumber)
        {
            this._accountNumber = accountNumber;
        }

        // Deposit -- Any positive deposit is allowed.
        public void Deposit(double amount)
        {
            if (amount > 0.0)
            {
                _balance += amount;
            }
        }

        // Withdraw -- You can withdraw any amount up to the
        //    balance; return the amount withdrawn.
        public double Withdraw(double withdrawal)
        {
            if (_balance <= withdrawal)
            {
                withdrawal = _balance;
            }
            _balance -= withdrawal;
            return withdrawal;
        }

        // GetString -- Return the account data as a string.
        public string GetString()
        {
            string s = String.Format("#{0} = {1:C}",
                                      GetAccountNumber(), GetBalance());
            return s;
        }
    }
}
