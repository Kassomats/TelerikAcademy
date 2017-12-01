using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDim._01
{
    class Program
    {
        private static int i;
        private static int length;

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int counter = 1;
            for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
            {
                for (int secondRow = row, col = 0; secondRow < matrix.GetLength(0); secondRow++, col++)
                {
                    matrix[secondRow, col] = counter++;
                }
            }
            for (int col = 1; col < matrix.GetLength(1); col++)
            {
                for (int secondCol = col, row = 0; secondCol < matrix.GetLength(1); secondCol++, row++)
                {
                    matrix[row, secondCol] = counter++;
                }

            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
