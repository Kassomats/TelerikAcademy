using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _21.SecretMessage
{
    public class Node
    {
        public Node(int times, string value)
        {
            this.Times = times;
            this.Value = value;
        }
        public int Times { get; set; }
        public string Value { get; set; }
    }
    class Program
    {

        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            Node nod = new Node(1, input);
            Printer(nod);
            
        }
        public static void Adder(string text, List<Node> list)
        {
            bool digitNotFound = true;
            string currentDigit = string.Empty;
            string currentString = string.Empty;
            int leftBr = 0;
            int rightBr = 0;


            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]) && digitNotFound)
                {
                    currentDigit = text[i].ToString();
                    if (char.IsDigit(text[i + 1]))
                    {
                        currentDigit += text[i + 1].ToString();
                        i++;
                        if (char.IsDigit(text[i + 2]))
                        {
                            currentDigit += text[i + 2].ToString();
                            i++;
                        }
                    }


                    digitNotFound = false;
                    continue;
                }
                if (!digitNotFound)
                {
                    currentString += text[i].ToString();
                    if (text[i] == '{')
                    {
                        leftBr++;
                    }
                    if (text[i] == '}')
                    {
                        rightBr++;
                    }
                    if (leftBr != 0 && leftBr == rightBr)
                    {

                        digitNotFound = true;
                        Node toAdd = new Node(int.Parse(currentDigit), currentString.Substring(1, currentString.Length - 2));
                        //input = input.Substring(currentDigit.Length + currentString.Length);

                        list.Add(toAdd);
                        currentString = string.Empty;

                    }
                }
            }
        }
        public static void Magic(string text)
        {
            List<Node> lister = new List<Node>();
            Adder(text, lister);

            foreach (var item in lister)
            {
                Printer(item);
            }
           


        }
        public static void Printer(Node node)
        {
            //for (int i = 0; i < node.Value.Length; i++)
            //{
            //    if (char.IsDigit(node.Value[i]))
            //    {
            //        Magic(node.Value);
            //    }

            int leftBr = 0;
            int rightBr = 0;
          
            for (int k = 0; k < node.Times; k++)
            {
                for (int i = 0; i < node.Value.Length; i++)
                {
                    if (node.Value[i] == '{')
                    {
                        leftBr++;
                    }
                    if (node.Value[i] == '}')
                    {
                        rightBr++;
                    }

                    if (char.IsLetter(node.Value[i]) && leftBr == rightBr)
                    {
                        Console.Write(node.Value[i]);
                    }

                    if (char.IsDigit(node.Value[i]) && leftBr == rightBr)
                    {
                        Magic(node.Value);
                    
                        if (char.IsDigit(node.Value[i + 1]))
                        {
                            if (char.IsDigit(node.Value[i + 2]))
                            {
                                i++;
                            }
                            i++;
                        }
                        leftBr = 0;
                        rightBr = 0;
                        break;
                    }
                }

                Stack<char> stack = new Stack<char>();
                for (int asd = node.Value.Length - 1; asd >= 0; asd--)
                {
                    if (node.Value[asd] == '}')
                    {
                        break;
                    }
                    stack.Push(node.Value[asd]);
                }
                Console.Write(string.Join("", stack));
            }
            

        }
    }
}