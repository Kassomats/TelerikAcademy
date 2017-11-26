using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad._23
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<char> charArray = new List<char>();
            char helper;
            for (int i = 0; i < input.Length-1; i++)
            {
                if (input[i] != input[i + 1])
                {
                    charArray.Add(input[i]);
                }
            }
            if (input[input.Length - 1] != charArray[charArray.Count-1])
            {
                charArray.Add(input[input.Length - 1]);
            }
            Console.WriteLine(String.Join("",charArray));
        }
    }
}
