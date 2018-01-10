using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.LongestSubsequance
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            Console.WriteLine(string.Join(" ",list));

           // List<int> longestFound = LongestSequance(list);
            List<int> negativesRemoved = NegativeRemover(list);

            //Console.WriteLine(string.Join(" ",longestFound));
            Console.WriteLine(string.Join(" ", negativesRemoved));
        }

        private static List<int> LongestSequance(List<int> list)
        {
            int longestItem = 0;
            int mostTimes = 0;
            int currentTimes = 1;

            for (int i = 0; i < list.Count()-1; i++)
            {
                if (list[i] == list[i+1])
                {
                    currentTimes++;
                }
                if (mostTimes < currentTimes)
                {
                    mostTimes = currentTimes;
                    longestItem = list[i];
                }
                if (list[i] != list[i + 1])
                {
                    currentTimes = 1;
                }
            }
            list.Clear();
            for (int i = 0; i < mostTimes; i++)
            {
                list.Add(longestItem);
            }
            return list;
        }
        private static List<int> NegativeRemover(List<int> list)
        {
            List<int> helperList = new List<int>();
            for (int i = 0; i < list.Count(); i++)
            {
                helperList.Add(list[i]);
            }
            foreach (var item in list)
            {
                if (item < 0)
                {
                    helperList.Remove(item);
                }
            }
            return helperList;
        }

    }
}
