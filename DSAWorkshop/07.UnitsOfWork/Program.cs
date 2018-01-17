using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;
namespace _07.UnitsOfWork
{
    class Program
    {
        static void Main(string[] args)
        {
            BigList<int> asd = new BigList<int>();
            asd.Add(3);
            asd.Insert(1, 5);
            foreach (var item in asd)
            {
                Console.WriteLine(item);
            }


        }
    }
}
