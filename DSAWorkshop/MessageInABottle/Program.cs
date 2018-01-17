using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageInABottle
{
    class Program
    {
        static string currentLetter = "no";
        static int currentDigit = -1;
        static string currentAnswerSequance = "-2";

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string cipher = Console.ReadLine();
            LinkedList<int> currentCode = new LinkedList<int>();
            Dictionary<int, string> dict = new Dictionary<int, string>();

            for (int i = 0; i < cipher.Length; i++)
            {

                if (char.IsLetter(cipher[i]))
                {
                    if (currentLetter != "no" && currentDigit != -1)
                    {
                        dict.Add(int.Parse(string.Join("", currentCode)), currentLetter);

                    }

                    currentLetter = cipher[i].ToString();
                    currentCode.Clear();
                }
                if (char.IsDigit(cipher[i]))
                {
                    currentCode.AddLast(int.Parse(cipher[i].ToString()));
                    currentDigit = int.Parse(cipher[i].ToString());

                    if (i == cipher.Length - 1)
                    {
                        dict.Add(int.Parse(string.Join("", currentCode)), currentLetter);
                    }
                }
            }


            for (int i = 1; i < input.Length; i++)
            { 

                for (int j = i; j < input.Length; j++)
                {

                }
            }


            foreach (var item in dict)
            {
                Console.WriteLine(item);
            }
        }
    }
}
