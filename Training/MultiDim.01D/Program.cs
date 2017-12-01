using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDim._01D
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            string dir = "down";
            int row = 0;
            int col = 0;
            int counter = 1;
            int matrixNext = 0;
            for (int times = 0; times < 10; times++)
            {
                if (dir == "down")
                {
                    for (int i = row; i <=n; i++)
                        if (row + 1 < n && matrix[row + 1, col] == 0)
                        {
                            row = i;
                            matrix[row, col] = counter++;
                        }
                        else
                        {
                            dir = "right";
                        }


                }
                else if (dir == "right")
                {
                    for (int i = col+1; i <n; i++)
                        if (col + 1 < n && matrix[row, col + 1] == 0)
                        {
                            col = i;
                            matrix[row, col] = counter++;
                        }
                        else
                        {
                            dir = "up";
                        }
                }
                else if (dir == "up")
                {
                    for (int i = row-1; i >= 0; i--)
                    {
                        if (i > 0 && matrix[i-1,col]==0)
                        {
                            row = i;
                            matrix[row, col] = counter++;
                        }

                    }
                }
                else if (dir == "left")
                {

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
