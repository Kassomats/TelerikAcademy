using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad._09
{
    class SortingArray
    {
        static void Main(string[] args)
        {
            int a =1234;
            int b = 1234;
            int c = a + b;
            string d = (c.ToString());
            d = new string(d.ToCharArray().Reverse().ToArray());
            Console.WriteLine(d);

        }
    }
}
