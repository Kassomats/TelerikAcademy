using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionFactoriel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fact(0));
        }
        static int Fact(int numbToFact)
        {
            if (numbToFact == 0)
            {
                return 1;
            }
            else
            {
                int result = numbToFact * Fact(numbToFact - 1);
                return result;
            }
        }
    }
}
