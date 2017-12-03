using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SneakyTheSnake
{
    class Program
    {
        static int currentRow = 0;
        static int currentCol = 0;

        static void Main(string[] args)
        {
            int[] matrixDims = Console.ReadLine().Split('x').Select(int.Parse).ToArray();
            char[,] theDen = new char[matrixDims[0], matrixDims[1]];
            MatrixBuilder(theDen.GetLength(0), theDen.GetLength(1), theDen);
            char[] moves = Console.ReadLine().Split(',').Select(char.Parse).ToArray();

            string dir = string.Empty;
            int length = 3;
            int movesCount = 0;

            for (int i = 0; i < moves.Length; i++)
            {
                movesCount++;
                if (movesCount % 5 == 0)
                {
                    length--;
                }

                if (moves[i] == 'd')
                {
                    currentCol++;
                    if (currentCol == theDen.GetLength(1))
                    {
                        currentCol = currentCol % theDen.GetLength(1);
                    }
                    if (theDen[currentRow, currentCol] == '@')
                    {
                        length++;
                        theDen[currentRow, currentCol] = '-';
                    }
                    if (theDen[currentRow, currentCol] == '%')
                    {
                        Console.WriteLine("Sneaky is going to hit a rock at [{0},{1}]", currentRow, currentCol);
                        return;
                    }
                }
                if (moves[i] == 's')
                {
                    currentRow++;
                    if (currentRow >= theDen.GetLength(0))
                    {
                        Console.WriteLine("Sneaky is going to be lost into the depths with length {0}", length);
                        return;
                    }
                    if (theDen[currentRow, currentCol] == '@')
                    {
                        length++;
                        theDen[currentRow, currentCol] = '-';
                    }
                    if (theDen[currentRow, currentCol] == '%')
                    {
                        Console.WriteLine("Sneaky is going to hit a rock at [{0},{1}]", currentRow, currentCol);
                        return;
                    }
                }
                if (moves[i] == 'a')
                {
                    currentCol--;
                    if (currentCol < 0)
                    {
                        currentCol += theDen.GetLength(1);
                    }
                    if (theDen[currentRow, currentCol] == '@')
                    {
                        length++;
                        theDen[currentRow, currentCol] = '-';
                    }
                    if (theDen[currentRow, currentCol] == '%')
                    {
                        Console.WriteLine("Sneaky is going to hit a rock at [{0},{1}]", currentRow, currentCol);
                        return;
                    }
                }
                if (moves[i] == 'w')
                {
                    currentRow--;
                    if (currentRow <0)
                    {
                        Console.WriteLine("Sneaky is going to be lost into the depths with length {0}", length);
                        return;
                    }

                    if (theDen[currentRow, currentCol] == '@')
                    {
                        length++;
                        theDen[currentRow, currentCol] = '-';
                    }
                    else if (theDen[currentRow, currentCol] == 'e')

                    {
                        Console.WriteLine("Sneaky is going to get out with length {0}", length);
                        return;
                    }
                    if (theDen[currentRow, currentCol] == '%')
                    {
                        Console.WriteLine("Sneaky is going to hit a rock at [{0},{1}]", currentRow, currentCol);
                        return;
                    }

                }

             
                if (length <= 0)
                {
                    Console.WriteLine("Sneaky is going to starve at [{0},{1}]", currentRow, currentCol);
                   
                    return;
                }
            }
            Console.WriteLine("Sneaky is going to be stuck in the den at [{0},{1}]", currentRow, currentCol);

        }



        private static void MatrixPrinter(char[,] theDen)
        {
            for (int i = 0; i < theDen.GetLength(0); i++)
            {
                for (int j = 0; j < theDen.GetLength(1); j++)
                {
                    Console.Write(theDen[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void MatrixBuilder(int rows, int cols, char[,] matrix)
        {
            for (int row = 0; row < rows; row++)
            {
                string colSymbols = Console.ReadLine();
                if (colSymbols.IndexOf('e') != -1)
                {
                    currentCol = colSymbols.IndexOf('e');
                }
                else
                {
                }
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = colSymbols[col];
                }
            }

        }
    }
}
