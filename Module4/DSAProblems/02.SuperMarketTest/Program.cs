using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace _02.SuperMarketTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var asd = new BigList<int>();
            asd.Add(0);
            asd.Add(1);
            asd.Add(2);
            asd.Add(3);

            asd.Insert(50, 10);
            foreach (var item in asd)
            {
                Console.WriteLine(item);
            }
        }
    }
}
