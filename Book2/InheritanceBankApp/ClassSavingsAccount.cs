using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceBankApp
{
    class SavingsAccount : BankAccount
    {
        private double _interestRate;

        public  SavingsAccount(double rate) : this(0, rate)
        {

        }

        public SavingsAccount(double starting, double rate) : base(starting)
        {
            this.InterestRate = rate;
        }

        public double InterestRate
        {
            get { return _interestRate * 100; }
            set { _interestRate = value / 100; }
        }

        public void AccrueInterest()
        {
            Balance += Balance * _interestRate;
        }
    }
}
