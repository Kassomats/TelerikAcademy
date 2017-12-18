using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Deposit : Account
    {
        public Deposit(Customers customer, decimal balance, decimal interestRate) : base(customer, balance, interestRate)
        {
        }
        //Deposit accounts have no interest if their balance is positive and less than 1000.
        public override decimal InterestForTime(int months)
        {
            if (Balance > 0 && Balance < 1000)
            {
                return 0;
            }
            else
            {
                return months * InterestRate;
            }
            
        }
        public void Withdraw(decimal a)
        {
            Balance -= a;
        }
    }
}
