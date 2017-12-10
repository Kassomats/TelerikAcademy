using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Backwards
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentIndex = int.Parse(Console.ReadLine());

            int[] array = Console.ReadLine().Split(',').Select(int.Parse).ToArray();

            string[] stepDirSize = Console.ReadLine().Split().ToArray();

            int forwardSum = 0;
            int backwardsSum = 0;

            while (stepDirSize[0] != "exit")
            {
                if (stepDirSize[1] == "forward")
                {
                    for (int i = 0; i < int.Parse(stepDirSize[0]); i++)
                    {
                        currentIndex += int.Parse(stepDirSize[2]);

                        forwardSum += array[currentIndex %array.Length];

                    }
                }
                else if (stepDirSize[1] == "backwards")
                {
                    for (int i = 0; i < int.Parse(stepDirSize[0]); i++)
                    {
                        currentIndex -= int.Parse(stepDirSize[2]);
                        while (currentIndex<0)
                        {
                            currentIndex += array.Length;
                        }
                        backwardsSum += array[currentIndex % array.Length];
                    }

                }


                stepDirSize = Console.ReadLine().Split().ToArray();
            }
            Console.WriteLine("Forward: {0}",forwardSum);
            Console.WriteLine("Backwards: {0}",backwardsSum);
           
        }
    }
}
