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
        static bool[,] boolTrix;
        static void Main(string[] args)
        {
            //Setting the labyrinth
            var myPossition = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var currRow = myPossition[0];
            var currCol = myPossition[1];

            var matrixDims = Console.ReadLine().Split().Select(int.Parse).ToArray();
            rows = matrixDims[0];
            cols = matrixDims[1];
            boolTrix = new bool[rows, cols];
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
            DFS(currRow, currCol, 0, int.Parse(matrix[currRow, currCol]));
            Console.WriteLine(currentCount);


        }
        static void DFS(int currentRow, int currentCol, int count, int previousCount)
        {
            if (currentRow < 0 || currentRow >= rows ||
                currentCol < 0 || currentCol >= cols ||
                matrix[currentRow, currentCol] == "#")
            {
                if (previousCount > currentCount)
                {
                    currentCount = previousCount;
                }
                return;
            }
            if (boolTrix[currentRow, currentCol])
            {
                if (count > currentCount)
                {
                    currentCount = count;
                }
                return;
            }
            else
            {
                var currentNumber = int.Parse(matrix[currentRow, currentCol]);
                boolTrix[currentRow, currentCol] = true;
                DFS(currentRow + currentNumber, currentCol, count + currentNumber, count);
                DFS(currentRow, currentCol + currentNumber, count + currentNumber, count);
                DFS(currentRow - currentNumber, currentCol, count + currentNumber, count);
                DFS(currentRow, currentCol - currentNumber, count + currentNumber, count);
                boolTrix[currentRow, currentCol] = false;
            }
        }
    }
}