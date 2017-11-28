using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad._12
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> array = Console.ReadLine().Split().Select(int.Parse).ToList();
            GetMin(array);
            GetMax(array);
            GetAverage(array);
            GetSum(array);
            GetProduct(array);
        }

        private static void GetProduct(List<int> array)
        {
            long a = 1;
            for (int i = 0; i < array.Count; i++)
            {
                a *= array[i];
            }
            Console.WriteLine(a);
        }

        private static void GetSum(List<int> array)
        {
            int a = array.Sum();
            Console.WriteLine(a);
        }

        private static void GetAverage(List<int> array)
        {
            double a = array.Average();
            Console.WriteLine("{0:F2}",a);
        }

        private static void GetMax(List<int> array)
        {
            int a = array.Max();
            Console.WriteLine(a);
        }

        static void GetMin(List<int> array)
        {
            int a = array.Min();
            Console.WriteLine(a);
        }
    }
}
