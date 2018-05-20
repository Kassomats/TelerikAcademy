using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.StringReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "petko";
            var reversed = string.Empty;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversed += input[i];
            }
            //var stack = new Stack<char>();
            //for (int i = 0; i < input.Length; i++)
            //{
            //    stack.Push(input[i]);
            //}
            //foreach (var item in stack)
            //{
            //    reversed += item;
            //}

            Console.WriteLine(reversed);
        }
    }
}
