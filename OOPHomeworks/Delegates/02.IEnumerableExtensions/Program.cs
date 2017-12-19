using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.IEnumerableExtensions
{
    class Program
    {

        //Implement a set of extension methods for IEnumerable<T>
        //that implement the following group functions: sum, product, min, max, average

        static void Main(string[] args)
        {
            IEnumerable<int> list = new List<int> { 1, 2, 3, 4, 5 };
            Console.WriteLine(list.Sum());
            Console.WriteLine(list.Product());
            Console.WriteLine(list.Min());
            Console.WriteLine(list.Max());
            Console.WriteLine(list.Average());


        }
    }
    public static class Extenstions
    {
        public static decimal Sum(this IEnumerable<int> list)
        {
            decimal sum = 0;
            foreach (var item in list)
            {
                sum += item;
            }
            return sum;
        }
        public static decimal Product(this IEnumerable<int> list)
        {
            decimal product = 1;
            foreach (var item in list)
            {
                product *= item;
            }
            return product;
        }
        public static decimal Min(this IEnumerable<int> list)
        {
            decimal min = decimal.MaxValue;
            foreach (var item in list)
            {
                if (item<min)
                {
                    min = item;
                }        
            }

            return min;
        }
        public static decimal Max(this IEnumerable<int> list)
        {
            decimal max = decimal.MinValue;
            foreach (var item in list)
            {
                if (item > max)
                {
                    max = item;
                }
            }

            return max;
        }
        public static decimal Average(this IEnumerable<int> list)
        {
            decimal sum = 0;
            foreach (var item in list)
            {
                sum += item;
            }
            return sum / list.Count();
        }
    }
}
