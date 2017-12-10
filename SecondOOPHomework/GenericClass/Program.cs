using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> array = new GenericList<int>();
            array.Add(5);
            array.Add(10);
            array.Add(15);

            int a = array.FindElement(2);
            Console.WriteLine(a);
        }
    }
}
