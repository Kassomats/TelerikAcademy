using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFSMatrix
{
    class Program
    {
        static int rows;
        static int cols;
        static bool[,] boolTrix;
        static int currentMax;
        static int largestMax;

        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            rows = input[0];
            cols = input[1];
            int[,] matrix = new int[rows, cols];
            boolTrix = new bool[rows, cols];

            for (int i = 0; i < input[0]; i++)
            {
                int[] filling = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int j = 0; j < input[1]; j++)
                {
                    matrix[i, j] = filling[j];
                   // boolTrix[i, j] = true;
                }
            }
            for (int i = 0; i < input[0]; i++)
            {

                for (int j = 0; j < input[1]; j++)
                {
                    DFS(i, j, matrix, boolTrix, matrix[i, j]);
                    currentMax = 0;
                }
            }
            Console.WriteLine(largestMax);


            //for (int i = 0; i < input[0]; i++)
            //{
            //    for (int j = 0; j < input[1]; j++)
            //    {
            //        Console.Write(matrix[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
        }
        public static void DFS(int currRow, int currCol, int[,] matrix, bool[,] boolearMatrix, int target)
        {
           
            
            if (currCol >= cols || currRow >= rows || currCol < 0 || currRow < 0 || boolearMatrix[currRow, currCol] == false)
            {
                return;
            }
         

            if (matrix[currRow, currCol] == target)
            {
                currentMax++;
                boolTrix[currRow, currCol] = false;
                if (largestMax < currentMax)
                {
                    largestMax = currentMax;
                }
                DFS(currRow + 1, currCol, matrix, boolTrix, target);
                DFS(currRow, currCol + 1, matrix, boolTrix, target);
                DFS(currRow - 1, currCol, matrix, boolTrix, target);
                DFS(currRow, currCol - 1, matrix, boolTrix, target);
            }



        }
    }
}
