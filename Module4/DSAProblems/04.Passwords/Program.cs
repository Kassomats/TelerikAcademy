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
        static int searchedPassword;
        static int count;
        //static List<string> answers;

        static void Main(string[] args)
        {
            lengthOfPass = int.Parse(Console.ReadLine());
            combination = Console.ReadLine();
            searchedPassword = int.Parse(Console.ReadLine());
            count = 0;
            var currentPassword = new StringBuilder();
            if (combination[0] == '<')
            {
                currentPassword.Append(0);
                FindNextNumb(10, 0, currentPassword);
                currentPassword.Clear();

                for (int i = 1; i < 10; i++)
                {
                    currentPassword.Append(i);
                    FindNextNumb(i, 0, currentPassword);
                    currentPassword.Clear();
                }

            }
            else if (combination[0] == '>')
            {
                for (int i = 1; i < 10; i++)
                {
                    currentPassword.Append(i);
                    FindNextNumb(i, 0, currentPassword);
                    currentPassword.Clear();
                }
            }
            else if (combination[0] == '=')
            {
                currentPassword.Append(0);
                FindNextNumb(10, 0, currentPassword);
                currentPassword.Clear();
                for (int i = 1; i < 10; i++)
                {
                    currentPassword.Append(i);
                    FindNextNumb(i, 0, currentPassword);
                    currentPassword.Clear();
                }
            }
           

        }
        static void FindNextNumb(int currentNumber, int indexInCommand, StringBuilder currentPassword)
        {
            if (currentPassword.Length == lengthOfPass)
            {
                count++;
                if (count==searchedPassword)
                {
                    Console.WriteLine(currentPassword.ToString());
                    Environment.Exit(0);
                }
                return;

            }
            switch (combination[indexInCommand])
            {
                case '<':
                    for (int i = 1; i < currentNumber; i++)
                    {
                        currentPassword.Append(i % 10);
                        FindNextNumb(i, indexInCommand + 1, currentPassword);
                        currentPassword.Length--;
                    }
                    indexInCommand += 1;
                    break;
                case '>':

                    if (currentNumber != 10)
                    {
                        currentPassword.Append(0);
                        FindNextNumb(10, indexInCommand+1, currentPassword);
                        currentPassword.Length--;
                    }

                    for (int i = currentNumber + 1; i <= 9; i++)
                    {
                        currentPassword.Append(i);
                        FindNextNumb(i, indexInCommand + 1, currentPassword);
                        currentPassword.Length--;
                    }
                    indexInCommand += 1;
                    break;
                case '=':
                    currentPassword.Append(currentNumber % 10);
                    indexInCommand += 1;
                    FindNextNumb(currentNumber, indexInCommand, currentPassword);
                    currentPassword.Length--;
                    break;
                default:
                    break;
            }
        }
    }
}
