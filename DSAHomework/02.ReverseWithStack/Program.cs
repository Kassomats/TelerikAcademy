using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ReverseWithStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            Console.Write("Number of ints=");
            int times = int.Parse(Console.ReadLine());
            for (int i = 0; i < times; i++)
            {
                int item = int.Parse(Console.ReadLine());
                stack.Push(item);
            }
            Console.WriteLine(string.Join(" ", stack));
        }
    }
}
