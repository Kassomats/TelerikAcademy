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

            string codeRdy = string.Empty;
            List<string> answers = new List<string>();
            Magic(input, dict, answers, codeRdy);
            Console.WriteLine(answers.Count());
            foreach (var item in answers)
            {
                Console.WriteLine(item);
            }



        }
        public static void Magic(string code, Dictionary<int, string> dict, List<string> answers, string currentMsg)
        {


            if (code.Length <= 0)
            {
                answers.Add(currentMsg);
                return;
            }

            foreach (var item in dict)
            {
                if (code.StartsWith(item.Key.ToString()))
                {
                    currentMsg += item.Value;
                    Magic(code.Substring(item.Key.ToString().Length), dict, answers, currentMsg);
                    currentMsg = currentMsg.Substring(item.Value.Length);
                }
            }



        }

    }
}