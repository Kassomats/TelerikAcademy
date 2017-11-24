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
            List<int> listOfSum = new List<int>();
            int sum = 1;
            int helper = 1;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int[] secondInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = secondInput[j];
                }
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    while (i + helper < array.GetLength(0) && array[i, j] == array[i + helper, j])
                    {
                        sum++;
                        helper++;
                    }
                    listOfSum.Add(sum);
                }
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    while (j + helper < array.GetLength(1) && array[i, j] == array[i, j + helper])
                    {
                        sum++;
                        helper++;
                    }
                    listOfSum.Add(sum);
                }
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    while (j + helper < array.GetLength(1) && i + helper < array.GetLength(0) && array[i, j] == array[i + helper, j + helper])
                    {
                        sum++;
                        helper++;
                    }
                    listOfSum.Add(sum);
                }
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    while (j - helper < array.GetLength(1) &&
                        i + helper < array.GetLength(0) &&
                        j - helper >= 0 &&
                        array[i, j] == array[i + helper, j - helper])
                    {
                        sum++;
                        helper++;
                    }
                    listOfSum.Add(sum);
                }
            }
            listOfSum.Sort();
            Console.WriteLine(listOfSum[listOfSum.Count - 1]);
        }
    }
}