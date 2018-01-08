using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Fact(5);
        }
        static void Fact(int a)
        {
            int count = 1;
            for (int i = 1; i <= a; i++)
            {
                count *= i;
            }
            Console.WriteLine(count);
        }
    }
}
