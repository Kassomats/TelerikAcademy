using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultidimensionalClasswork
{
    class Zad1
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int counter = 1;
            char howToFill = char.Parse(Console.ReadLine());
            if (howToFill == 'a')
            {
                for (int i = 0; i < matrix.GetLength(1); i++)
                {
                    for (int j = 0; j < matrix.GetLength(0); j++)
                    {
                        matrix[j, i] = counter;
                        counter++;
                    }
                }
            }
            else if (howToFill == 'b')
            {

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j % 2 == 0)
                    {
                        for (int i = 0; i < n; i++)
                        {
                            matrix[i, j] = counter;
                            counter++;
                        }

                    }
                    else
                    {
                        for (int i = n - 1; i >= 0; i--)
                        {
                            matrix[i, j] = counter;
                            counter++;
                        }
                    }
                }
            }
            else if (howToFill == 'c')
            {
                int row = 0;
                int col = 0;
                int filler = 1;
                for (int i = 0; i < n * n; i++)
                {
                    for (int i = 0; i < length; i++)
                    {

                    }
                }
            }
            else if (howToFill == 'd')
            {

            }
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    if (j == matrix.GetLength(0) - 1)
                    {
                        Console.Write("{0}", matrix[i, j]);
                    }
                    else
                    {
                        Console.Write("{0} ", matrix[i, j]);
                    }

                }
                Console.WriteLine();
            }


        }
    }
}
