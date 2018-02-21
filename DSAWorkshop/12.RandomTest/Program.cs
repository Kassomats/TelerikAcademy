using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.RandomTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "абвгде1234";
            Console.OutputEncoding = UTF8Encoding.UTF8;

            char[] inp = str.ToCharArray();
            Array.Reverse(inp);
            Console.WriteLine(string.Join("",inp));

            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < str.Length; i++)
            {
                stack.Push(str[i]);            }
            Console.WriteLine(string.Join("", stack));

            char[] myArr = new char[str.Length];
            for (int i = str.Length-1; i >= 0; i--)
            {
                myArr[str.Length - i-1] = str[i];
            }
            Console.WriteLine(string.Join("",myArr));

            List<char> lis = new List<char>();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                lis.Add( str[i]);
            }
            Console.WriteLine(string.Join("", lis));

        }
    }
}
