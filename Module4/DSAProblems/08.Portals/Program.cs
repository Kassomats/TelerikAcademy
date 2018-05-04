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
        static void Main(string[] args)
        {
            //Setting the labyrinth
            var myPossition = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var currRow = myPossition[0];
            var currCol = myPossition[1];

            var matrixDims = Console.ReadLine().Split().Select(int.Parse).ToArray();
            rows = matrixDims[0];
            cols = matrixDims[1];

            var matrix = new string[rows, cols];
            var answers = new List<int>();
            var DFSQueue = new Queue<int>();
            for (int i = 0; i < rows; i++)
            {
                var input = Console.ReadLine().Split().ToArray();
                for (int k = 0; k < cols; k++)
                {
                    matrix[i, k] = input[k];
                }
            }
            DFSQueue.Enqueue(int.Parse(matrix[currRow, currCol]));
            while (DFSQueue.Any())
            {
                var current = DFSQueue.Dequeue();
                currentCount += current;
                if (currRow + current >= rows && currRow - current < 0 &&
                    currCol + current >= cols && currCol - current < 0
                    )
                {
                    answers.Add(currentCount);
                }
                else
                {
                    if (currRow + current < rows)
                    {
                        if (matrix[currRow + current, currCol] == "#")
                        {
                            break;
                        }
                        else
                        {
                        DFSQueue.Enqueue(int.Parse(matrix[currRow + current, currCol]));

                        }
                    }
                    if (currCol + current < cols)
                    {
                        if (matrix[currRow, currCol + current] == "#")
                        {
                            break;
                        }
                        else
                        {
                        DFSQueue.Enqueue(int.Parse(matrix[currRow, currCol+current]));
                        }
                    }
                    if (currRow - current >= 0)
                    {
                        if (matrix[currRow - current, currCol] == "#")
                        {
                            break;
                        }
                        else
                        {
                        DFSQueue.Enqueue(int.Parse(matrix[currRow - current, currCol ]));
                        }
                    }
                    if (currCol - current <= 0)
                    {
                        if (matrix[currRow, currCol - current] == "#")
                        {
                            break;
                        }
                        else
                        {
                        DFSQueue.Enqueue(int.Parse(matrix[currRow, currCol - current]));
                        }
                    }
                }
            }
            PrintMatrix(matrix);
            foreach (var item in answers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(currentCount);


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
