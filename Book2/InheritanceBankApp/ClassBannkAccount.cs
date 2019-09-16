using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceBankApp
{
    class BankAccount
    {
        static int startingAccount = 1000;

        private double _balance;
        public int _accountNumber;

        public BankAccount() : this(0) { }

        public BankAccount(double startingBalance)
        {
            _accountNumber = ++startingAccount;
            if (startingBalance < 0)
            {
                Console.WriteLine("The value used in less than zero. Starting with zero");
                _balance = 0;
            }
            else
            {
                _balance = startingBalance;
            }
        }

        public double Balance
        {
            get { return _balance; }
            protected set { _balance = value; }

        }

        public void Deposit(double amount)
        {
            if (amount >= 0)
            {
                Balance += amount;
            }
        }

        public void Withdraw(double amount)
        {
            if (amount >= Balance)
            {
                Balance = 0;
            }
            else
            {
                Balance -= amount;
            }
        }

        public void ToString()
        {
            Console.WriteLine("Account: {0} Balance: {1:C}", _accountNumber, _balance);
        }

    }
}
