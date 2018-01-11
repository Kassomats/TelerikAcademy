using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFollowingSequance
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int start = input[0];
            queue.Enqueue(start);

            int temp = 0;
            int counter = 1;
            Console.WriteLine("Element{0} is {1}", 1, start);
            //int lastNumber = input[1];

            while(counter!=50)
            {
                temp = queue.Dequeue();

                queue.Enqueue(temp + 1);
                counter++;
                Console.WriteLine("Element{0} is {1}", counter, temp + 1);
                if (counter == 50)
                {
                    return;
                }

                queue.Enqueue(2 * temp + 1);
                counter++;
                Console.WriteLine("Element{0} is {1}", counter, 2 * temp + 1);
                if (counter == 50)
                {
                    return;
                }
                
                queue.Enqueue(temp + 2);
                counter++;
                Console.WriteLine("Element{0} is {1}", counter, temp + 2);
                if (counter == 50)
                {
                    return;
                }
                Console.WriteLine();

            }
           
        }
        //S1 = N;
        //S2 = S1 + 1;
        //S3 = 2*S1 + 1;
        //S4 = S1 + 2;
    }
}
