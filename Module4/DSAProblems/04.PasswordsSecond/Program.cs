using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Passwords
{
    class Program
    {
        static int lengthOfPass;
        static string combination;
        //static List<string> answers;

        static void Main(string[] args)
        {
            lengthOfPass = int.Parse(Console.ReadLine());
            combination = Console.ReadLine();
            int searchedPassword = int.Parse(Console.ReadLine());

            var answers = new List<string>();
            var currentPassword = new StringBuilder();
            if (combination[0] == '<')
            {
                for (int i = 10; i >= 0; i--)
                {
                    currentPassword.Append(i % 10);
                    FindNextNumb(i, 0, currentPassword, answers);
                    currentPassword.Clear();
                }

            }
            else if (combination[0] == '>')
            {
                for (int i = 1; i < 10; i++)
                {
                    currentPassword.Append(i);
                    FindNextNumb(i, 0, currentPassword, answers);
                    currentPassword.Clear();
                }
            }
            else if (combination[0] == '=')
            {
                for (int i = 1; i < 10; i++)
                {
                    currentPassword.Append(i);
                    FindNextNumb(i, 0, currentPassword, answers);
                    currentPassword.Clear();
                }
            }
            answers.Sort();
            //foreach (var item in answers)
            //{
            //    Console.WriteLine(item);
            //}
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine(answers[i]);
            }

        }
        static void FindNextNumb(int currentNumber, int indexInCommand, StringBuilder currentPassword, List<string> answers)
        {
            if (currentPassword.Length == lengthOfPass)
            {
                answers.Add(currentPassword.ToString());
               
                return;
            }
            switch (combination[indexInCommand])
            {
                case '<':
                    for (int i = currentNumber - 1; i > 0; i--)
                    {
                        currentPassword.Append(i % 10);
                        FindNextNumb(i, indexInCommand + 1, currentPassword, answers);
                        currentPassword.Length--;
                    }
                    indexInCommand += 1;
                    break;
                case '>':
                    for (int i = currentNumber + 1; i <= 10; i++)
                    {
                        currentPassword.Append(i % 10);

                        FindNextNumb(i, indexInCommand + 1, currentPassword, answers);
                        currentPassword.Length--;
                    }
                    indexInCommand += 1;
                    break;
                case '=':
                    currentPassword.Append(currentNumber % 10);
                    indexInCommand += 1;
                    FindNextNumb(currentNumber, indexInCommand, currentPassword, answers);
                    currentPassword.Length--;
                    break;
                default:
                    break;
            }
        }
    }
}