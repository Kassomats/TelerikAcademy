using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem08NumbersAsArrayv2
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySize = int.Parse(Console.ReadLine());
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            PrintInAscendingOrder(array);
        }

        static void PrintInAscendingOrder(int[] array)
        {
            Array.Sort(array);
            Console.Write(array[0]);

            for (int i = 1; i < array.Length; i++)
            {
                Console.Write(" " + array[i]);
            }
            

        }
    }
}
