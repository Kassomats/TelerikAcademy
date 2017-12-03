using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace SecretNumberal._01
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToArray();


            BigInteger[] array = new BigInteger[4];



            for (int i = 0; i < input.Length; i++)
            {
                List<int> firstNumb = new List<int>();
                string word = input[i];
                while (word.Length > 0)
                {
                    if (word.IndexOf("hristofor") == 0)
                    {
                        firstNumb.Add(3);
                        word = word.Remove(0, 9);
                    }
                    else if (word.IndexOf("hristo") == 0)
                    {
                        firstNumb.Add(0);
                        word = word.Remove(0, 6);
                    }
                    else if (word.IndexOf("tosho") == 0)
                    {
                        firstNumb.Add(1);
                        word = word.Remove(0, 5);
                    }
                    else if (word.IndexOf("pesho") == 0)
                    {
                        firstNumb.Add(2);
                        word = word.Remove(0, 5);
                    }
                    else if (word.IndexOf("vladimir") == 0)
                    {
                        firstNumb.Add(7);
                        word = word.Remove(0, 8);
                    }
                    else if (word.IndexOf("vlad") == 0)
                    {
                        firstNumb.Add(4);
                        word = word.Remove(0, 4);
                    }
                    else if (word.IndexOf("haralampi") == 0)
                    {
                        firstNumb.Add(5);
                        word = word.Remove(0, 9);
                    }
                    else if (word.IndexOf("zoro") == 0)
                    {
                        firstNumb.Add(6);
                        word = word.Remove(0, 4);
                    }
                }

                array[i] = BigInteger.Parse(string.Join("", firstNumb));
            }
            BigInteger product = 1;

            for (int i = 0; i < array.Length; i++)
            {
            
                array[i] = Convert.ToInt64(array[i].ToString(), 8);
                product *= array[i];
                
            }
                
            
            Console.WriteLine(product);
        }
    }
}
