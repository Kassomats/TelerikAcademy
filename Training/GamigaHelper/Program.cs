using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamigaHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0];
            int m = input[1];
            int[,] matrix = new int[n,m];
            MatrixFiller(matrix,n,m);
            MatrixPrinter(matrix);
        }

        private static void MatrixFiller(int[,] matrix,int n, int m)
        {
            int counter = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0, rowHelper =i; j < m && rowHelper>=0; j++,rowHelper--)
                {
                    matrix[rowHelper, j] = counter;
                    counter++;
                }

            }
            for (int j = 1; j < m; j++)
            {
                for (int i = n - 1, colHelper = j; i >= 0 && colHelper < m; i--,colHelper++)
                {
                    matrix[i, colHelper] = counter;
                    counter++;
                }

            }
        }

        private static void MatrixPrinter(int[,] matrix)
        {
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
