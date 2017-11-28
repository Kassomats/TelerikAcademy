using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad._08
{
    class NumberAsArray
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] firstArrayHelper = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondArrayHelper = Console.ReadLine().Split().Select(int.Parse).ToArray();
            ReturnSumAndPrint(firstArrayHelper, secondArrayHelper);
        }

        private static void ReturnSumAndPrint(int[] firstArrayHelper, int[] secondArrayHelper)
        {
            int sum = 0;
            int remainer = 0;
            List<int> convertedArray = new List<int>();
            int longerArray = Math.Max(firstArrayHelper.Length, secondArrayHelper.Length);
            for (int i = 0; i < longerArray; i++)
            {
                sum = 0;
                if (i < firstArrayHelper.Length)
                {
                    sum += firstArrayHelper[i];
                }
                if (i < secondArrayHelper.Length)
                {
                    sum += secondArrayHelper[i];
                }
                convertedArray.Add(sum);
            }
            Console.Write(convertedArray[0]);
            for (int i = 1; i < convertedArray.Count; i++)
            {
                Console.Write(" " + convertedArray[i]);
            }
        }
    }
}
