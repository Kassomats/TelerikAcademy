using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GoshoCode._04
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyWord = Console.ReadLine();
            int numberLines = int.Parse(Console.ReadLine());
            StringBuilder text = new StringBuilder();
            string finalAnswer = "";
           // List<string> wordsHolder = new List<string>();
            for (int i = 0; i < numberLines; i++)
            {
                string textInput = Console.ReadLine();
                text.Append(textInput);
            }
            string[] sentenceHolder = Regex.Split(text.ToString(), @"(?<=[!.])");

            foreach (var item in sentenceHolder)
            {
                if (item.IndexOf(keyWord) != -1)
                {
                    if (item.IndexOf("!") != -1)
                    {
                       string b = item.Trim().TrimEnd('!');
                        string[] c = b.Split().ToArray();
                        finalAnswer = string.Join("", c);
                        finalAnswer = finalAnswer.Remove(finalAnswer.IndexOf(keyWord));
                  
                    }
                    else if (item.IndexOf(".") != -1)
                    {
                        string b = item.Trim().TrimEnd('.');
                        string[] c = b.Split().ToArray();
                        finalAnswer = string.Join("", c);
                        finalAnswer = finalAnswer.Remove(0,finalAnswer.IndexOf(keyWord)+keyWord.Length);
               
                    }

                    
                }
            }
            int sum = 0;
            for (int i = 0; i < finalAnswer.Length; i++)
            {
                sum += (int)finalAnswer[i] *keyWord.Length;
            }
            Console.WriteLine(sum);
            //Console.WriteLine(text);
        }
    }
}
