using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.SomeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var hello = new LinkedList<int>();
            hello.AddLast(2);
            hello.AddLast(5);
            hello.AddLast(10);
            var item = hello.ElementAt(1);
            hello.AddLast(hello.ElementAt(1));
            //Console.WriteLine(item);
            //Console.WriteLine(hello.ElementAt(1));
            Console.WriteLine(string.Join(" ",hello));
            

        }
    }
}
