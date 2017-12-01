using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitShiftMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] matrixRange = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int firstRage = int.Parse(Console.ReadLine());
            int secondRage = int.Parse(Console.ReadLine());
            int numberOfMove = int.Parse(Console.ReadLine());

            decimal[] posCode = Console.ReadLine().Split().Select(decimal.Parse).ToArray();

            int[,] matrix = new int[firstRage, secondRage];
            MatrixFiller(matrix);
            int sum = 0;
            int currentCol = 0;
            int currentRow = firstRage - 1;
            int coeff = Math.Max(firstRage, secondRage);
            for (int i = 0; i < numberOfMove; i++)
            {
                decimal colStopper = Math.Round(posCode[i] % coeff);
                decimal rowStopper = Math.Round(posCode[i] / coeff);
                if (currentCol < colStopper)
                {
                    for (int col = currentCol; col <= colStopper; col++)
                    {
                        sum += matrix[currentRow, col];
                        matrix[currentRow, col] = 0;
                        currentCol = col;
                    }
                }
                else if (currentCol > colStopper)
                {
                    for (int col = currentCol; col >= colStopper; col--)
                    {
                        sum += matrix[currentRow, col];
                        matrix[currentRow, col] = 0;
                        currentCol = col;
                    }
                }
                if (currentRow < rowStopper)
                {
                    for (int row = currentRow; row <= rowStopper; row++)
                    {
                        sum += matrix[row, currentCol];
                        matrix[row, currentCol] = 0;
                        currentRow = row;
                    }

                }
                else if (currentRow > rowStopper)
                {
                    for (int row = currentRow; row >= rowStopper; row--)
                    {
                        sum += matrix[row, currentCol];
                        matrix[row, currentCol] = 0;
                        currentRow = row;
                    }
                }
                Console.WriteLine(colStopper);
                Console.WriteLine(rowStopper);
            }
            Console.WriteLine(sum);

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void MatrixFiller(int[,] matrix)
        {
            int a = matrix.GetLength(0);
            int b = matrix.GetLength(1);
            matrix[a - 1, 0] = 1;
            int buildHelper = 2;
            for (int row = a - 2; row >= 0; row--)
            {
                for (int rowHelper = row, col = 0; rowHelper < a; rowHelper++, col++)
                {
                    matrix[rowHelper, col] = buildHelper;
                }
                buildHelper = buildHelper * 2;
            }
            for (int col = 1; col < b; col++)
            {
                for (int colHelper = col, row = 0; colHelper < b; colHelper++, row++)
                {
                    matrix[row, colHelper] = buildHelper;
                }
                buildHelper = buildHelper * 2;
            }
        }
    }
}
