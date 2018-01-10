using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAndSearchAlgorithms
{
    public static class SortableCollection
    {
        public static int LinearSearch(int target, int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                {
                    return i;
                }
            }
            return -1;
        }
        public static int BinSearch(int target, int[] arr)
        {
            int start = 0;
            int end = arr.Length-1;
            return BinarySearch(arr, start, end, target);
        }
        public static int BinarySearch(int[] arr, int start, int end, int target)
        {
            int middle = (start + end) / 2;
            if (arr[middle] == target)
            {
                return middle;
            }
            else if (start == end)
            {
                return -1;
            }
            else if (arr[middle] > target)
            {
                end = middle - 1;
                return BinarySearch(arr, start, end, target);
            }
            else if (arr[middle] < target)
            {
                start = middle + 1;
                return BinarySearch(arr, start, end, target);
            }
            return -11111;


        }
        public static void Shuffle(int[] arr)
        {
            Random rand = new Random();


            for (int i = 0; i < arr.Length; i++)
            {
                // Use Next on random instance with an argument.
                // ... The argument is an exclusive bound.
                //     So we will not go past the end of the array.
                int r = i + rand.Next(arr.Length - i);
                int t = arr[r];
                arr[r] = arr[i];
                arr[i] = t;
            }
        }
        public static int BinarySearchIterative(int key ,int[] arr)
        {
           
            int min = 0;
            int max = arr.Length - 1;
            while (min <= max )
            {
                int mid = (min + max) / 2;
                if (key == arr[mid] )
                {
                    return mid;
                }
                else if (key < arr[mid])
                {
                    max = mid - 1;
                }
                else if (key > arr[mid])
                {
                    min = mid + 1;
                }
            }
            return -1;
        }
    }
}
