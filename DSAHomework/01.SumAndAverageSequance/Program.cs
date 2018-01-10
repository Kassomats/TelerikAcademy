using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SumAndAverageSequance
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lister = new List<int>();
            string input = Console.ReadLine().Trim();
            while (input != "")
            {
                lister.Add(int.Parse(input));
                input = Console.ReadLine().Trim();
            }
            Console.WriteLine("Average = {0}",lister.Average());
            Console.WriteLine("Sum = {0}", lister.Sum());

           
        }
    }
}
