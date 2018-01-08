using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFSMatrix
{
    class Program
    {
        static int row;
        static int col;
        static int[][] matrix;
        static bool[,] usedMatrix;
        static int currentArea;
        static int greatestArea;

        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();
            row = input[0];
            col = input[1];
            usedMatrix = new bool[row, col];
            matrix = new int[row][];

            for (int i = 0; i < row; i++)
            {
                var filler = Console.ReadLine().Split().Select(int.Parse).ToArray();
                matrix[i] = filler;
            }
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (!usedMatrix[i,j])
                    {
                        currentArea = 0;
                        DFS(matrix, i, j, matrix[i][j]);
                    }

                }
            }
            Console.WriteLine(greatestArea);
             //PrintMatrix(matrix);

        }

        private static void DFS(int[][] currentMatrix, int currentRow, int currentCol, int currentValue)
        {
            if (currentRow < 0 || currentCol < 0 || currentRow > row - 1 || currentCol > col - 1)
                return;
            if (matrix[currentRow][currentCol] != currentValue)
                return;
            if (usedMatrix[currentRow, currentCol])
                return;

            currentArea++;
            usedMatrix[currentRow, currentCol] = true;
            greatestArea = greatestArea < currentArea ? currentArea : greatestArea;

            DFS(matrix, currentRow + 1, currentCol, currentValue);
            DFS(matrix, currentRow - 1, currentCol, currentValue);
            DFS(matrix, currentRow, currentCol + 1, currentValue);
            DFS(matrix, currentRow, currentCol - 1, currentValue);
        }

        public static void PrintMatrix(int[][] matrix)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
