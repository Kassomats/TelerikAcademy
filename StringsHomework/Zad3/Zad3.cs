using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3
{
    class Zad3
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool isCorrect = true;
            int open = 0;
            int closed = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    open++;
                }
                else if (input[i] == ')')
                {
                    closed++;
                }
                if (open<closed)
                {
                    isCorrect = false;
                }

            }
            if (open != closed)
            {
                isCorrect = false;
            }
            if (isCorrect)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }
        }
    }
}
