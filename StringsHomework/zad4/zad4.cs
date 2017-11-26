using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace zad4
{
    class zad4
    {
        static void Main(string[] args)
        {
            string pattern = Console.ReadLine().ToLower(); ;
            string text = Console.ReadLine().ToLower();
            int counter = 0;
            while (text.IndexOf(pattern) != -1)
            {
                text = text.Remove(0, text.IndexOf(pattern) + pattern.Length);
                counter++;
            }
            Console.WriteLine(counter);
        }
    }
}
