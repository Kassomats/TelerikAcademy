using System;
using System.Collections.Generic;

namespace _02.Speeds
{
    struct Program
    {
        static void Main(string[] args)
        {
            int longestGroupCount = 0;
            int highestGroupSpeed = 0;
            int currentGroupCount = 0;
            int currentGroupSpeed = 0;
            int currenHeadCarSpeed;

            var numOfCars = int.Parse(Console.ReadLine());
            var lane = new int[numOfCars];
            for (int i = 0; i < numOfCars; i++)
            {
                lane[i] = int.Parse(Console.ReadLine());
            }
            currenHeadCarSpeed = lane[0];
            currentGroupSpeed = lane[0];
            currentGroupCount = 1;

            for (int i = 1; i < lane.Length - 1; i++)
            {
                if (lane[i] > currenHeadCarSpeed)
                {
                    currentGroupCount += 1;
                    currentGroupSpeed += lane[i];
                }
                else
                {
                    if (currentGroupCount > longestGroupCount)
                    {
                        longestGroupCount = currentGroupCount;
                        highestGroupSpeed = currentGroupSpeed;
                    }

                    else if (currentGroupCount == longestGroupCount)
                    {
                        if (highestGroupSpeed < currentGroupSpeed)
                        {
                            highestGroupSpeed = currentGroupSpeed;
                        }
                    }
                    currentGroupCount = 1;
                    currentGroupSpeed = lane[i];
                    currenHeadCarSpeed = lane[i];
                }
            }

            //the last car
            if (lane[lane.Length - 1] > currenHeadCarSpeed)
            {
                currentGroupCount += 1;
                currentGroupSpeed += lane[lane.Length - 1];
            }
            if (currentGroupCount > longestGroupCount)
            {
                longestGroupCount = currentGroupCount;
                highestGroupSpeed = currentGroupSpeed;
            }
            else if (currentGroupCount == longestGroupCount)
            {
                if (highestGroupSpeed < currentGroupSpeed)
                {
                    highestGroupSpeed = currentGroupSpeed;
                }
            }
            currentGroupCount = 1;
            currentGroupSpeed = lane[lane.Length - 1];
            currenHeadCarSpeed = lane[lane.Length - 1];
            Console.WriteLine(highestGroupSpeed);
        }
    }
}