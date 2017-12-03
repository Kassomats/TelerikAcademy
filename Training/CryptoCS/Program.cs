using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace CryptoCS
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNum = Console.ReadLine(); //in 26 base
            string subOrAdd = Console.ReadLine();                                    
            string secondNum = Console.ReadLine(); //in 7 base

            BigInteger firstNumIn10 = ConvertFrom26(firstNum);
            BigInteger secondNumIn10 = ConvertFrom7(secondNum);

            if (subOrAdd == "+")

            {
                BigInteger result = firstNumIn10 + secondNumIn10;
                Console.WriteLine(ConvertTo9(result));
            }
            else if (subOrAdd == "-")
            {
                BigInteger result = firstNumIn10 - secondNumIn10;
                Console.WriteLine(ConvertTo9(result));
            }
        }

        static BigInteger ConvertFrom7(string num)
        {
            string charset = "0123456";
            BigInteger result = 0;
            foreach (char digit in num)
            {
                result = result * 7 + charset.IndexOf(digit);
            }
            return result;
        }
        static BigInteger ConvertFrom26(string num)
        {
            string charset = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToLower();
            BigInteger result = 0;
            foreach (char digit in num)
            {
                result = result * 26 + charset.IndexOf(digit);
            }
            return result;
        }
        static BigInteger ConvertTo9(BigInteger num)

        {
            string result = string.Empty;
            string charset = "012345678";
            
            while (num > 0)
            {
                BigInteger index = num % 9;
                result = charset[(int)index] + result;
                num = num / 9;
            }
            return BigInteger.Parse(result);

        }
    }
}
