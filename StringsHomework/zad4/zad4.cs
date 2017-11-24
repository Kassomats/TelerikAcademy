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
            string pattern = Console.ReadLine();
            string text = Console.ReadLine();

           
            int count = 0;
            foreach (Match match in Regex.Matches(text, pattern))
            {
                count++;
            }

            Console.WriteLine(count);

        }
    }
}
