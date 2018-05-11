using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorythms
{
    class Program
    {
        static void Main(string[] args)
        {
            //setting up unsorted list
            var random = new Random();
            var unsortedList = new List<int>();
            var sw = new Stopwatch();
            var numOfElements = 100000000;
            for (int i = 0; i < numOfElements; i++)
            {
                unsortedList.Add(random.Next(10000000));
            }
            //^^

            

            //var myList = new List<int> { 6, 1, 2, 111000000, 3 };
            //var sorted = CountingSort(myList, 111000000);

            sw.Start();
            var sorted = MergeSort(unsortedList);
            //var sorted = CountingSort(unsortedList, numOfElements);
            sw.Stop();
            //foreach (var item in sorted)
            //{
            //    Console.WriteLine(item);
            //}
            //for (int i = 0; i < sorted.Count(); i++)
            //{
            //    while (sorted[i] > 0)
            //    {
            //        Console.WriteLine(i);
            //        sorted[i]--;
            //    }
            //}

            Console.WriteLine(sw.Elapsed.TotalMilliseconds);

        }//6 1 2 10 3 7 7
        public static int[] CountingSort(List<int> unsorted, int elementCount)
        {
            var countingArray = new int[elementCount + 1];

            foreach (var item in unsorted)
            {
                countingArray[item]++;
            }
            return countingArray;
        }

        public static void BubbleSort(List<int> unsorted)
        {
            for (int i = 0; i < unsorted.Count - 1; i++)
            {
                for (int j = 0; j < unsorted.Count - 1; j++)
                {
                    if (unsorted[j] > unsorted[j + 1])
                    {
                        var temp = unsorted[j];
                        unsorted[j] = unsorted[j + 1];
                        unsorted[j + 1] = temp;
                    }
                }
            }
        }
        public static void BubbleSortWithBool(List<int> unsorted)
        {
            var sorted = false;
            while (!sorted)
            {
                sorted = true;
                for (int j = 0; j < unsorted.Count - 1; j++)
                {
                    if (unsorted[j] > unsorted[j + 1])
                    {
                        var temp = unsorted[j];
                        unsorted[j] = unsorted[j + 1];
                        unsorted[j + 1] = temp;
                        sorted = false;
                    }
                }
            }
        }
        public static void InsertionSort(List<int> unsorted)
        {
            for (int i = 0; i < unsorted.Count - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (unsorted[j - 1] > unsorted[j])
                    {
                        //swap
                        var temp = unsorted[j - 1];
                        unsorted[j - 1] = unsorted[j];
                        unsorted[j] = temp;
                    }
                }
            }
        }
        public static List<int> MergeSort(List<int> unsorted)
        {
            //split
            var n = unsorted.Count();
            if (n == 1)
            {
                return unsorted;
            }
            var firstHalf = unsorted.GetRange(0, n / 2 + n % 2);
            var secondHalf = unsorted.GetRange(n / 2 + n % 2, n / 2);
            var newFirstColl = MergeSort(firstHalf);
            var newSecondColl = MergeSort(secondHalf);
            return Merge(newFirstColl, newSecondColl);
            //return MergeWithArray(newFirstColl,newSecondColl); 
        }
        public static List<int> Merge(List<int> firstColl, List<int> secondColl)
        {
            var temp = new List<int>();
            while (firstColl.Count() > 0 && secondColl.Count > 0)
            {
                if (firstColl[0] < secondColl[0])
                {
                    temp.Add(firstColl[0]);
                    firstColl.Remove(firstColl[0]);
                }
                else
                {
                    temp.Add(secondColl[0]);
                    secondColl.Remove(secondColl[0]);
                }
            }
            while (firstColl.Count > 0)
            {
                temp.Add(firstColl[0]);
                firstColl.Remove(firstColl[0]);
            }
            while (secondColl.Count > 0)
            {
                temp.Add(secondColl[0]);
                secondColl.Remove(secondColl[0]);
            }
            return temp;
        }
        //public static List<int> MergeWithArray(List<int> firstColl, List<int> secondColl)
        //{
        //    var temp = new List<int>();
        //    var smallerCollectionCount = firstColl.Count < secondColl.Count ? firstColl.Count : secondColl.Count;
        //    var biggerCollectionCount = firstColl.Count <= secondColl.Count ? secondColl.Count : firstColl.Count;

        //    for (int i = 0; i < smallerCollectionCount; i++)
        //    {
        //        if (firstColl.Count==secondColl.Count)
        //        {
        //            if (firstColl[i] < secondColl[i])
        //            {
        //                temp.Add(firstColl[i]);
        //            }
        //            else
        //            {
        //                temp.Add(secondColl[i]);
        //            }
        //        }
        //        else if (firstColl[i] < secondColl[i])
        //        {
        //            temp.Add(firstColl[i]);
        //        }
        //        else
        //        {
        //            temp.Add(secondColl[i]);
        //        }
        //    }
        //    for (int i = smallerCollectionCount; i < biggerCollectionCount; i++)
        //    {
        //        if (firstColl.Count != smallerCollectionCount)
        //        {
        //            temp.Add(firstColl[i]);
        //        }
        //        else
        //        {
        //            temp.Add(secondColl[i]);
        //        }
        //    }
        //    return temp;
        ////}



    }
}

