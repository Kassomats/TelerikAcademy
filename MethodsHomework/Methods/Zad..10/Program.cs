using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad._._10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            GetFactorial(n);
        }

         static void GetFactorial(int n)
        {
            BigInteger helper = n;
            if (n == 0)
            {
                helper = 1;
            }
            else
            {
                for (int i = 1; i < n; i++)
                {
                    helper *= i;
                }
            }

            Console.WriteLine(helper);
        }
    }
}
