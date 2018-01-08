using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] secondInput = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 1; i <= secondInput[0]; i++)
            {
                for (int j = i; j <= secondInput[0]; j++)
                {
                    Console.Write(i);
                    for (int k = 0; k < secondInput[1]-1; k++)
                    {
                        Console.Write(" "+j);
                    }

                    Console.WriteLine();
                }

            }
        }
    }
}
