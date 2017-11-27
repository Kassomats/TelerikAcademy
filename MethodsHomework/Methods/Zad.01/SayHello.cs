using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad._01
{
    class SayHello
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            PrintGreeter(input);
        }
        static void PrintGreeter(string input)
        {
            Console.WriteLine("Hello, {0}!",input);
        }
    }
}
