
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CokiSkoki
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int[] buildings = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] jumps = new int[buildings.Length];
            
            for (int i = buildings.Length - 1; i >= 0; i--)
            {
                jumps[i] = 1 + CheckNextBuildings(i, buildings, jumps);
            }

            Console.WriteLine(jumps.Max());
            Console.WriteLine(string.Join(" ", jumps));
        }

        private static int CheckNextBuildings(int i, int[] buildings, int[] jumps)
        {
            for (int j = i + 1; j < buildings.Length; j++)
            {
                if (buildings[i] < buildings[j])
                {
                    return jumps[j];
                }
            }
            return -1;
        }
    }
}