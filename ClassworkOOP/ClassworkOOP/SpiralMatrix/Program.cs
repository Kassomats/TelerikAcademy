using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiralMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int[,] matrix = new int[input, input];
            int currentRow = matrix.GetLength(0)-1;
            int currentCol = 0;
            int counter = 1;
            string dir = "left";

            while (counter <= input * input)
            {
                if (dir == "right")
                {
                    for (int j = currentCol; j < input && matrix[currentRow, currentCol] == 0; j++)
                    {
                        matrix[currentRow, j] = counter;
                        counter++;
                        currentCol++;
                    }
                    currentCol--;
                    currentRow++;
                    dir = "down";
                }
                if (dir == "down")
                {
                    for (int i = currentRow; i < input && matrix[currentRow, currentCol] == 0; i++)
                    {
                        matrix[i, currentCol] = counter;
                        counter++;
                        currentRow++;
                    }
                    currentRow--;
                    currentCol--;
                    dir = "left";
                }
                if (dir == "left")
                {
                    for (int i = currentCol; i >= 0 && matrix[currentRow, currentCol] == 0; i--)
                    {
                        matrix[currentRow, i] = counter;
                        counter++;
                        currentCol--;
                    }
                    currentCol++;
                    currentRow--;
                    dir = "up";

                }
                if (dir == "up")
                {
                    for (int i = currentRow; i >= 0 && matrix[currentRow, currentCol] == 0; i--)
                    {
                        matrix[i, currentCol] = counter;
                        counter++;
                        currentRow--;
                    }
                    currentRow++;
                    currentCol++;
                    dir = "right";
                }
            }

            for (int i = 0; i < input; i++)
            {
                for (int j = 0; j < input; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
