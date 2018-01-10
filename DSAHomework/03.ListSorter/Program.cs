using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SumAndAverageSequance
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lister = new List<int>();
            string input = Console.ReadLine().Trim();
            while (input != "")
            {
                lister.Add(int.Parse(input));
                input = Console.ReadLine().Trim();
            }
            Sorter(lister);
            Console.WriteLine(string.Join(" ",lister));
           
        }
        public static void Sorter(List<int> list)
        {
            LinkedList<int> helperList = new LinkedList<int>();
            while (list.Count != 0)
            {
                int min = int.MaxValue;
               
                for (int i = 0; i < list.Count(); i++)
                {
                    if (list[i] < min)
                    {
                        min = list[i];
                    }
                }
                list.Remove(min);
                helperList.AddLast(min);
            }
            foreach (var item in helperList)
            {
                list.Add(item);
            }
                
        }
    }
}
