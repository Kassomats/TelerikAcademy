using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Mortgage : Account
    {
        public Mortgage(Customers customer, decimal balance, decimal interestRate) :
            base(customer, balance, interestRate)
        {
        }
        //Mortgage accounts have ½ interest for the first 12 months for companies
        //    and no interest for the first 6 months for individuals.
        public override decimal InterestForTime(int months)
        {
            if (this.Customer == Customers.companies)
            {
                if (months <= 12)
                {
                    return InterestRate * months / 2;
                }
                else if (months >= 12)
                {
                    return (InterestRate * (months - 12)) + (InterestRate * 12 / 2);
                }
            }
            else
            {
                if (months <= 6)
                {
                    return 0;
                }
                else
                {
                    return (months - 6) * InterestRate;
                }
            }
            return -12312;
        }
    }
}