using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.RemoveOddTimedItems
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            TimeEachOccur(list);
            //Console.WriteLine(string.Join(" ", list));

        }
        private static void TimeEachOccur(List<int> list)
        {
            List<int> helperList = new List<int>();
            for (int i = 0; i < list.Count(); i++)
            {
                helperList.Add(list[i]);
            }

            helperList.Sort();
            while (helperList.Count() > 0)
            {
                var current = helperList[0];
                List<int> holder = helperList.FindAll(x => x == current);
                Console.WriteLine("{0} -> {1} times",current, holder.Count());
                helperList.RemoveAll(x => x == current);
            }
        }
    }
}
