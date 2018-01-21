using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02._1_solution_MessagesInBottle
{
    class Program
    {
        static void Main(string[] args)
        {
            string code = Console.ReadLine();
            string input = Console.ReadLine();
            string pattern = @"([A-Z]+)(\d+)";

            SortedDictionary<char, string> dict = new SortedDictionary<char, string>();

            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match item in matches)
            {
                char a = item.Groups[1].Value[0];
                string b = item.Groups[2].Value;

                if (!dict.ContainsKey(a))
                {
                    dict.Add(a, b);
                }
            }
            StringBuilder messageBuild = new StringBuilder();
            List<string> answers = new List<string>();

            Decode(code, dict, messageBuild, answers);

            Console.WriteLine(answers.Count);
            if (answers.Count > 0)
            {
                Console.WriteLine(string.Join("\n", answers));
            }


        }
        public static void Decode(string input, SortedDictionary<char, string> dict,
            StringBuilder msgBuilder, List<string> answers)
        {
            if (input == "")
            {
                answers.Add(msgBuilder.ToString());
                return;
            }
            foreach (var item in dict)
            {
                char letter = item.Key;
                string code = item.Value;

                if (input.StartsWith(code))
                {
                    msgBuilder.Append(letter);

                    string restOfMessage = input.Remove(0,code.Length);

                    Decode(restOfMessage, dict, msgBuilder, answers);

                    msgBuilder.Length--;
                }
            }


        }
    }
}
