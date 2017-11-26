using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad10
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<char> charList = new List<char>();
            for (int i = 0; i < input.Length; i++)
            {
                charList.Add((char)input[i]);
            }
            int helper;

            for (int i = 0; i < charList.Count; i++)
            {
                helper = (int)charList[i];
                Console.Write("\\u{0:X4}", helper);
            }
        }
    }
}
