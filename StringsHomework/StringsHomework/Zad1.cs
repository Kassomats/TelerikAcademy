using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsHomework
{
    class Zad1
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] array = input.ToCharArray();
            Array.Reverse(array);
            Console.WriteLine(array);
        }
    }
}
