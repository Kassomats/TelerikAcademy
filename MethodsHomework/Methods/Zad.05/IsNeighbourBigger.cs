using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad._05
{
    class IsNeighbourBigger
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] arrayInput = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            bool bigger = false;
            int counter = 0;
            for (int i = 1; i < size-1; i++)
            {
               bigger =  Checker(i, arrayInput);
                if (bigger)
                {
                    counter += 1;
                }
            }
            Console.WriteLine(counter);
        }
        static bool Checker(int position, int[] arr)
        {
            bool isBigger = false;
            if (arr[position] > arr[position - 1] && arr[position] > arr[position + 1])
            {
                isBigger = true;
            }
            return isBigger;
        }
    }

}
