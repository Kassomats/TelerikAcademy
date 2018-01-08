using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Pesho";
            input = Reverse(input);
            
            Console.WriteLine(input);
        }
        public static string Reverse(string strToRev)
        {
            
            if (strToRev.Count() == 1)
            {
                return strToRev;
            }
            else
            {
                string result = strToRev[strToRev.Count() - 1] + Reverse(strToRev.Substring(0, strToRev.Count() - 1));
                return result;
            }
        }
    }
}
