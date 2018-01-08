using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace DSAHomework
{
    class PathOne
    {
        static void Main(string[] args)
        {
            BigInteger input = BigInteger.Parse(Console.ReadLine());
            int counter = 0;
            bool goUp;
            while (input != 1)
            {
                if (input % 2 == 0)
                {
                    input = input / 2;
                    counter++;
                }
                else if (input == 3)
                {
                    input--;
                    counter++;
                }
                else
                {
                    goUp = GoToUpper(input);
                    if (goUp)
                    {
                        input++;
                        counter++;
                    }
                    else if (!goUp)
                    {
                        input--;
                        counter++;
                    }
                }
                //Console.WriteLine(input);
            }
            Console.WriteLine(counter);
        }
        static bool GoToUpper(BigInteger input)
        {
            int counterGoUp = 0;
            int counterGoDown = 0;
            BigInteger inputUp = input + 1;
            BigInteger inputDown = input - 1;
            while (inputUp % 2 == 0)
            {
                inputUp = inputUp / 2;
                counterGoUp++;
            }
            while (inputDown % 2 == 0)
            {
                inputDown = inputDown / 2;
                counterGoDown++;
            }
            if (counterGoUp > counterGoDown)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
