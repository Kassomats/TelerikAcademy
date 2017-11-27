using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad._07
{
    class Reverser
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            decimal a = ChangerMethod(input);
            Console.WriteLine(a);
        }
        static decimal ChangerMethod(string here)
        {
            string help = new string(here.ToCharArray().Reverse().ToArray());
            return decimal.Parse(help);

        }
    }
}
