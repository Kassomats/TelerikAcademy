using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace SendMetheCode._01
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            BigInteger[] inputArray = new BigInteger[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                inputArray[i] = int.Parse(input[i].ToString());
            }

            BigInteger result = 0;
            BigInteger arrIndex = 0;

            for (int index = inputArray.Length; index >= 1; index--)
            {
                if (index % 2 == 1)
                {
                    result += inputArray[int.Parse(arrIndex.ToString())] * index * index;
                }
                else if (index % 2 == 0)
                {
                    result += inputArray[int.Parse(arrIndex.ToString())] * inputArray[int.Parse(arrIndex.ToString())] * index;
                }
                arrIndex++;
            }

            if (result % 10 == 0)
            {
                Console.WriteLine(result);
                Console.WriteLine("Big Vik wins again!");
            }
            else if (result % 10 != 0)
            {
                BigInteger messageLength = result % 10;
                BigInteger startOfMessage = (result % 26);

                string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                int helper = 0;
                Console.WriteLine(result);

                for (int i = 0; i < messageLength; i++)
                {
                    Console.Write(alphabet[(int.Parse(startOfMessage.ToString()) + helper) % 26]);
                    helper++;
                }
            }
        }
    }
}
