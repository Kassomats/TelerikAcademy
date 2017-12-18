using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Loan : Account
    {
        public Loan(Customers customer, decimal balance, decimal interestRate) : base(customer, balance, interestRate)
        {
        }
        public override decimal InterestForTime(int months)
        {
            if (this.Customer == Customers.individuals)
            {
                if (months <= 3)
                {
                    return 0;
                }
                else
                {
                    return (months-3) * InterestRate;
                }
            }
            else  
            {
                if (months <= 2)
                {
                    return 0;
                }
                else
                {
                    return (months - 2) * InterestRate;
                }
            }

            
        }
    }
}
