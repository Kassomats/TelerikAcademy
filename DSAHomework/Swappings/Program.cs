using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swappings
{
    class Program
    {


        static void Main(string[] args)
        {
            int firstInput = int.Parse(Console.ReadLine());
            int[] secondInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            LinkedList<int> storage = new LinkedList<int>();
            

            // List<string> stringList = new List<string>();

            for (int i = 1; i <= firstInput; i++)
            {
                storage.AddLast(i);
            }
            foreach (var item in secondInput)
            {
                var current = storage.Find(item);
                var currentLastNode = storage.Last;

                while (storage.Last.Value != current.Value)
                {
                    storage.AddFirst(storage.Last.Value);
                    storage.Remove(storage.Last);
                }
                if (current == currentLastNode)
                {
                    while (storage.First.Value != current.Value)
                    {
                        storage.AddAfter(current, current.Previous.Value);
                        storage.Remove(current.Previous);
                    }
                }
                else
                {
                    while (current.Previous.Value != currentLastNode.Value)
                    {
                        storage.AddAfter(current, current.Previous.Value);
                        storage.Remove(current.Previous);
                    }
                }
                


            }
            Console.WriteLine(string.Join(" ", storage));
        }
    }
}
