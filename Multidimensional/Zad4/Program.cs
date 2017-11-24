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
            int[,] matrix = new int[input[0], input[1]];
            int sum = 1;
            int helper = 1;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] secondInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = secondInput[j];
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    while (j + helper < matrix.GetLength(1) && matrix[i, j] == matrix[i, j + helper])
                    {
                        sum++;
                        helper++;
                    }
                   
                }
            }
            Console.WriteLine(sum);

        }
    }
}