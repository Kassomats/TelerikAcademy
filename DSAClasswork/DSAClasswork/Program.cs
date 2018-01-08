using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAClasswork
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 200; i < 300; i++)
            {
                int number = i;
                int result = Check_Prime(number);

                if (result == 0)
                {
                    //Console.WriteLine("{0} is not a prime number", number);
                }
                else
                {
                    Console.WriteLine("{0} is  a prime number", number);
                }
            }


        }

        private static int Check_Prime(int number)
        {
            int i;
            for (i = 2; i <= number - 1; i++)
            {
                if (number % i == 0)
                {
                    return 0;
                }
            }
            if (i == number)
            {
                return 1;
            }
            return 0;
        }

    }
}

