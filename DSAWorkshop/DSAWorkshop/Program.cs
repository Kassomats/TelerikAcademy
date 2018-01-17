using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int[] buildings = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int jumps = 0;
            int currentBuildHeight = 0;
          
            LinkedList<int> myList = new LinkedList<int>();

            for (int i = 0; i < input; i++)
            {
                currentBuildHeight = buildings[i];
                jumps = 0;
                for (int j = i + 1; j < input; j++)
                {
                    if (currentBuildHeight < buildings[j])
                    {
                        currentBuildHeight = buildings[j];
                        jumps++;
                    }
                }
                myList.AddLast(jumps);

                //if (longestJumps < jumps)
                //{
                //    longestJumps = jumps;
                //}

            }

            // Console.WriteLine(longestJumps);
            Console.WriteLine(myList.Max());
            Console.WriteLine(string.Join(" ", myList));

        }
    }
}