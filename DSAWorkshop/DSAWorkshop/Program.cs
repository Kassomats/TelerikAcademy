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
           
            int highestBuilding =0;
            int currentBuildHeight = 0;

            Stack<int> myList = new Stack<int>();

            for (int i = input - 1; i >= 0; i--)
            {
                currentBuildHeight = buildings[i];

                if (currentBuildHeight > highestBuilding)
                {
                    highestBuilding = currentBuildHeight;
                    myList.Push(0);
                    continue;
                }

                jumps = 0;

                for (int j = i + 1; j < input; j++)
                {
                    if (currentBuildHeight < buildings[j])
                    {
                        currentBuildHeight = buildings[j];
                        jumps++;
                    }
                    if (currentBuildHeight == highestBuilding)
                    {
                        break;
                    }
                }
                myList.Push(jumps);

            }
            Console.WriteLine(myList.Max());
            Console.WriteLine(string.Join(" ", myList));

            //
            //static void Main(string[] args)
            //{
            //    int input = int.Parse(Console.ReadLine());
            //    int[] buildings = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //    int[] jumps = new int[buildings.Length];

            //    for (int i = buildings.Length - 1; i >= 0; i--)
            //    {
            //        jumps[i] = 1 + CheckNextBuildings(i, buildings, jumps);
            //    }

            //    Console.WriteLine(jumps.Max());
            //    Console.WriteLine(string.Join(" ", jumps));
            //}

            //private static int CheckNextBuildings(int i, int[] buildings, int[] jumps)
            //{
            //    for (int j = i + 1; j < buildings.Length; j++)
            //    {
            //        if (buildings[i] < buildings[j])
            //        {
            //            return jumps[j];
            //        }
            //    }
            //    return -1;
            //}
            //
        }
    }
}