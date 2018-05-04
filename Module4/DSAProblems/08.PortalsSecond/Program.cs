using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Portals
{
    class Program
    {
        static int rows;
        static int cols;
        static int currentCount;
        static string[,] matrix;
        static bool[,] isVisitedMatrix;
        static void Main(string[] args)
        {
            //Setting the labyrinth
            var myPossition = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var currRow = myPossition[0];
            var currCol = myPossition[1];

            var matrixDims = Console.ReadLine().Split().Select(int.Parse).ToArray();
            rows = matrixDims[0];
            cols = matrixDims[1];
            isVisitedMatrix = new bool[rows, cols];
            matrix = new string[rows, cols];
            //filling the matrix
            for (int i = 0; i < rows; i++)
            {
                var input = Console.ReadLine().Split().ToArray();
                for (int k = 0; k < cols; k++)
                {
                    matrix[i, k] = input[k];
                }
            }
            //logic for dfs
            DFS(currRow, currCol, 0, 0);
            // PrintMatrix(matrix);
            Console.WriteLine(currentCount);


        }
        static void DFS(int currentRow, int currentCol, int count, int previousCount)
        {
            if (currentRow < 0 || currentRow >= rows ||
                currentCol < 0 || currentCol >= cols ||
                isVisitedMatrix[currentRow, currentCol] ||
                matrix[currentRow, currentCol] == "#")
            {
                if (previousCount > currentCount)
                {
                    currentCount = previousCount;
                }
                return;
            }
            
            else
            {
                var currentNumber = int.Parse(matrix[currentRow, currentCol]);
                isVisitedMatrix[currentRow,currentCol] = true;
                DFS(currentRow + currentNumber, currentCol, count + currentNumber, count);
                DFS(currentRow, currentCol + currentNumber, count + currentNumber, count);
                DFS(currentRow - currentNumber, currentCol, count + currentNumber, count);
                DFS(currentRow, currentCol - currentNumber, count + currentNumber, count);
                isVisitedMatrix[currentRow, currentCol] = false;
            }
        }
        static void PrintMatrix(string[,] matr)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int k = 0; k < cols; k++)
                {
                    Console.Write(matr[i, k] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
