using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public abstract class Account
    {
        private Customers customer;
        private decimal balance;
        private decimal interestRate;
        public Account(Customers customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public Customers Customer { get => customer; set => customer = value; }
        public decimal Balance { get => balance; set => balance = value; }
        public decimal InterestRate { get => interestRate; set => interestRate = value; }

        public void Deposit(decimal a)
        {
            Balance += a;
        }
        public virtual decimal InterestForTime(int months)
        {
            return months * InterestRate;
        }
    }
}
