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
            list = OddOccurRemover(list);
            Console.WriteLine(string.Join(" ", list));

        }
        private static List<int> OddOccurRemover(List<int> list)
        {
            List<int> returningList = new List<int>();
            for (int i = 0; i < list.Count(); i++)
            {
                returningList.Add(list[i]);
            }

            while (list.Count() > 0)
            {
                var current = list[0];

                List<int> holder = list.FindAll(x => x == current);

                if (holder.Count() % 2 == 1)
                {
                    returningList.RemoveAll(x => x == current);
                }

                list.RemoveAll(x => x == current);
            }
            return returningList;
        }
    }
}
