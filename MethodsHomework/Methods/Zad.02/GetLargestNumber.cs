using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad._02
{
    class GetLargestNumber
    {
        static void Main(string[] args)
        {

            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            GetMax(input[0], input[1],input[2]);
        }
        static void GetMax(int a, int b, int c)
        {
            if (a < b)
            {
                a = b;
            }
            if (a < c)
            {
                a = c;
            }
            Console.WriteLine(a);
        }
    }
}
