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
            int[] firstArray = new int[sizes[0]];
            int[] secondArray = new int[sizes[1]];
            int[] firstArrayHelper = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondArrayHelper = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < firstArrayHelper.Length; i++)
            {
                firstArray[i] = firstArrayHelper[i];
            }
            for (int k = 0; k < secondArrayHelper.Length; k++)
            {
                secondArray[k] = secondArrayHelper[k];
            }
            string sum = CrazyMethod(firstArray, secondArray);
            if (sum.Length == 1)
            {
                Console.WriteLine(sum[sum.Length-1]);
            }
            else
            {
                for (int i = 0; i < sum.Length - 1; i++)
                {
                    Console.Write(sum[i] + " ");
                }
                Console.Write(sum[sum.Length - 1]);
            }
            
        }

        static string CrazyMethod(int[] arrayOne, int[] arrayTwo)
        {
            int a = int.Parse(String.Join("", arrayOne.Reverse()));
            int b = int.Parse(String.Join("", arrayTwo.Reverse()));
            int c = a + b;
            string d = c.ToString();
            d = new string(d.ToCharArray().Reverse().ToArray());
            return d;
        }
    }
}
