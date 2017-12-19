using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIQN
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> asd = new List<int> { 1, 2, 3, 4, 5, 6 };
            asd = asd.ToList();
            foreach (var item in asd)
            {
                Console.WriteLine(item);
            }
        }
    }
}
