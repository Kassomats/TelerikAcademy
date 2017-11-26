using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Zad8
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = Console.ReadLine();
            string text = Console.ReadLine();
            string[] sentenceHolder = text.Split('.').Select(x => x.Trim()).ToArray();
            List<char> seperators = new List<char>();
            for (int i = 0; i < text.Length; i++)
            {
                if (!char.IsLetter(text[i]) && !seperators.Contains(text[i]))
                {
                    seperators.Add(text[i]);
                }
            }

            char[] sepArray = seperators.ToArray();
            List<string> answer = new List<string>();


            for (int i = 0; i < sentenceHolder.Length; i++)
            {
                string[] words = sentenceHolder[i].Split(sepArray).ToArray();

                for (int j = 0; j < words.Length; j++)
                {
                    if (words[j] == pattern)
                    {
                        answer.Add(sentenceHolder[i]);
                        break;
                    }
                    else
                    {
                    }
                }
            }
            if (answer.Count > 0)
            {
                for (int i = 0; i < answer.Count - 1; i++)
                {
                    Console.Write(answer[i] + ". ");
                }
                Console.Write(answer[answer.Count - 1] + '.');
            }
        }
    }
}
