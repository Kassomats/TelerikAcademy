using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.LastTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] arr = new char[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                arr[i] = input[i];
            }
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
