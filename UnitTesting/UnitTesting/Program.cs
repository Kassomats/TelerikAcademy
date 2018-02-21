using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UnitTesting
{
    public class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            a = Reverser(a);

            Console.WriteLine(a);
        }
        public static string Reverser(string a)
        {
            string rev = string.Empty;
            for (int i = a.Length - 1; i >= 0; i--)
            {
                rev+=(a[i]);
            }
            return rev;

            //Console.WriteLine(rev);
        }
    }
}
