using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1Shuffle
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var lastNumber = input[0];
            var numbersToBeMoved = input[1];

            var movingNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var dict = new Dictionary<int, LinkedListNode<int>>();

            LinkedList<int> numbers = new LinkedList<int>();


            for (int i = 1; i <= lastNumber; i++)
            {
                numbers.AddLast(i);
                dict.Add(i, numbers.Last);
            }


            for (int i = 0; i < numbersToBeMoved; i += 1)
            {
                var currentNumber = movingNumbers[i];


                if (currentNumber % 2 == 0)
                {
                    var nodeToAddAfter = numbers.Find(currentNumber / 2);

                    // var nodeToAddAfter = new LinkedListNode<int>(currentNumber / 2);
                    numbers.Remove(currentNumber);
                    numbers.AddAfter(nodeToAddAfter, currentNumber);
                }
                else
                {

                    if (currentNumber * 2 < lastNumber)
                    {
                        var nodeToAddAfter = numbers.Find(currentNumber * 2);
                        numbers.Remove(currentNumber);
                        numbers.AddAfter(nodeToAddAfter, currentNumber);
                    }
                    else
                    {
                        if (currentNumber == lastNumber)
                        {
                            continue;
                        }

                        var nodeToAddAfter = numbers.Find(lastNumber);
                        numbers.Remove(currentNumber);
                        numbers.AddAfter(nodeToAddAfter, currentNumber);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}