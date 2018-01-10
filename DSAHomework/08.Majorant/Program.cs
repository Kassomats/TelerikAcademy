using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Majorant
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 2, 2, 3, 3, 2, 3, 4, 3, 3 };
            //Console.ReadLine().Split().Select(int.Parse).ToList();
            Majorant(list);
            //Console.WriteLine(string.Join(" ", list));
        }
        private static void Majorant(List<int> list)
        {
            List<int> helperList = new List<int>();
            for (int i = 0; i < list.Count(); i++)
            {
                helperList.Add(list[i]);
            }
            while (helperList.Count() > 0)
            {
                var current = helperList[0];
                List<int> holder = helperList.FindAll(x => x == current);
                if (holder.Count() >= list.Count() / 2 + 1)
                {
                    Console.WriteLine("{0} -> {1} times", current, holder.Count());
                }
                helperList.RemoveAll(x => x == current);
            }
        }
    }
}
