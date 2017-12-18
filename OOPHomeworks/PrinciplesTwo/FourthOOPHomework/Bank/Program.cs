using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Account first = new Mortgage(Customers.individuals, 10, 1);

            Deposit second = new Deposit(Customers.companies, 100, 10);

            Account third = new Loan(Customers.individuals, 500, 0.5m);

            second.Deposit(100);
            second.Withdraw(250);
            Console.WriteLine(second.Balance);
        }
    }
}
