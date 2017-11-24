using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Array.Sort(input);
            int k = int.Parse(Console.ReadLine());
            Array.BinarySearch(input, k);
            
        }
    }
}
