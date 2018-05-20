using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MSLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new LinkedList<int>();
            list.AddLast(3);
            list.AddLast(3);
            list.AddLast(3);
            Console.WriteLine(string.Join("",list));
        }
    }
}
