using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2
{
    class Zad2
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[,] array = new int[input[0], input[1]];
            List<int> listSums = new List<int>();
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int[] secondInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = secondInput[j];
                }
            }
            for (int i = 0; i < array.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < array.GetLength(1) - 2; j++)
                {
                    sum = array[i, j] + array[i, j + 1] + array[i, j + 2] +
                             array[i + 1, j] + array[i + 1, j + 1] + array[i + 1, j + 2] +
                             array[i + 2, j] + array[i + 2, j + 1] + array[i + 2, j + 2];
                    listSums.Add(sum);
                }
            }
            listSums.Sort();
            Console.WriteLine(listSums[listSums.Count - 1]);
        }
    }
}
