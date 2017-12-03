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
                            col++;
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
                            row--;
                            dir = "up";
                        }
                }
                else if (dir == "up")
                {
                    for (int i = row-1; i >= 0; i--)
                    {
                        if (i > 0 && matrix[i - 1, col] == 0)
                        {
                            row = i;
                            matrix[row, col] = counter++;
                        }
                        else
                        {
                            col--;
                            dir = "left";
                        }

                    }
                }
                else if (dir == "left")
                {
                    for (int i = col-1; i >= 0; i--)
                    {
                        if (i > 0 && matrix[i - 1, col] == 0)
                        {
                            row = i;
                            matrix[row, col] = counter++;
                        }
                        else
                        {
                            col--;
                            dir = "left";
                        }

                    }
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


//private static void FillTheMatrixD()
//{
//    bool isDown = true;
//    bool isRight = false;
//    bool isUp = false;
//    bool isLeft = false;

//    while (counter <= matrix.GetLength(0) * matrix.GetLength(1))
//    {
//        matrix[row, col] = counter++;
//        if (isDown)
//        {
//            if (row + 1 >= matrix.GetLength(0) || matrix[row + 1, col] != 0)
//            {
//                col++;
//                isDown = false;
//                isRight = true;
//            }
//            else
//            {
//                row++;
//            }
//        }
//        else if (isRight)
//        {
//            if (col + 1 >= matrix.GetLength(1) || matrix[row, col + 1] != 0)
//            {
//                row--;
//                isRight = false;
//                isUp = true;
//            }
//            else
//            {
//                col++;
//            }
//        }
//        else if (isUp)
//        {
//            if (row - 1 < 0 || matrix[row - 1, col] != 0)
//            {
//                col--;
//                isUp = false;
//                isLeft = true;
//            }
//            else
//            {
//                row--;
//            }
//        }
//        else if (isLeft)
//        {
//            if (col - 1 < 0 || matrix[row, col - 1] != 0)
//            {
//                row++;
//                isLeft = false;
//                isDown = true;
//            }
//            else
//            {
//                col--;
//            }
//        }
//    }
//}