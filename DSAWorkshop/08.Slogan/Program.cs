using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CokiSkoki
{
    class Program
    {
        static void Main()
        {
            int numbers = int.Parse(Console.ReadLine());
            for (int i = 0; i < numbers; i++)
            {
                string[] words = Console.ReadLine().Split();
                string cipher = Console.ReadLine();

                StringBuilder currentAnswer = new StringBuilder();
                List<string> result = new List<string>();
                HashSet<string> imposs = new HashSet<string>();
                Decode(cipher, words, currentAnswer, result,imposs);

                if (result.Count == 0)
                {
                    Console.WriteLine("NOT VALID");
                }
                foreach (var item in result)
                {
                    Console.WriteLine(item.TrimEnd());
                }
            }

        }
        public static void Decode(string cipher, string[] words,
            StringBuilder currentAnswer, List<string> result, HashSet<string> imposs)
        {

            if (cipher.Length == 0)
            {
                result.Add(currentAnswer.ToString());

                return;
            }
            if (result.Count > 0)
            {
                return;
            }
            if (imposs.Contains(cipher))
            {
                return;
            }

            foreach (var item in words)
            {
                string test = item;
                if (cipher.StartsWith(item))
                {
                    currentAnswer.Append(item + " ");
                    test = string.Empty;
                    string restOfMessage = cipher.Substring(item.Length);
                    Decode(restOfMessage, words, currentAnswer, result, imposs);

                    currentAnswer.Length -= item.Length + 1;
                }
            }
            imposs.Add(cipher);
            return;
        }
    }
}