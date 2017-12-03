using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCS
{
    class Program
    {
        static void Main(string[] args)
        {
            string letters = Console.ReadLine();

            BigInteger[] numsIn26 = new BigInteger[letters.Length];
            for (int i = 0; i < letters.Length; i++)
            {
                numsIn26[i] = (letters[i] - 'a');
            }
            BigInteger firstNumber = ConvertFromAnyBase(numsIn26, 26);

            char operation = Convert.ToChar(Console.ReadLine());

            string numIn7 = Console.ReadLine();
            BigInteger[] numsIn7 = new BigInteger[numIn7.Length];
            for (int i = 0; i < numIn7.Length; i++)
            {
                numsIn7[i] = int.Parse(numIn7[i].ToString());
            }
            BigInteger secondNumber = ConvertFromAnyBase(numsIn7, 7);

            BigInteger result = 0;
            if (operation == '+')
            {
                result = firstNumber + secondNumber;
            }
            else if (operation == '-')
            {
                result = firstNumber - secondNumber;
            }

            Console.WriteLine(ConvertTo9Base(result));
        }


        static BigInteger ConvertFromAnyBase(BigInteger[] array, int numBase)
        {
            BigInteger sum = 0;
            double power = 0;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                sum += (array[i] * (BigInteger)(Math.Pow(numBase, power)));
                power++;
            }

            BigInteger result = BigInteger.Parse(sum.ToString());
            return result;
        }

        static BigInteger ConvertTo9Base(BigInteger number)
        {
            int numBase = 9;
            List<BigInteger> remainders = new List<BigInteger>();

            int i = 1;
            BigInteger calc = number;
            while (calc >= numBase)
            {
                BigInteger remain = calc % numBase;
                remainders.Add(remain);
                calc = calc / numBase;
                i++;
            }

            StringBuilder sb = new StringBuilder();
            sb.Append(calc);
            for (int j = remainders.Count - 1; j >= 0; j--)
            {
                sb.Append(remainders[j]);
            }
            string numAsString = sb + "";
            BigInteger result = BigInteger.Parse(numAsString);
            return result;
        }
    }
}