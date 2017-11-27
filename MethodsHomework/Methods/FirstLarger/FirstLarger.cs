using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLarger
{
    class FirstLarger
    {
        private static int position;

        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] inputArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int number = 0;
            for (int i = 1; i < size-1; i++)
            {
                 number = Checker(i, inputArr);
                if (number != -1)
                {
                    break;
                }
            }
            Console.WriteLine(number);
        }

        static int Checker(int i, int[] inputArr)
        {
            if (inputArr[i] > inputArr[i - 1] && inputArr[i] > inputArr[i + 1])
            {
                return i;
            }
            else
            {
                return -1;
            }
            
        }
    }
}
