using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAndSearchAlgorithms
{
    class Search
    {
        static void Main(string[] args)
        {

            int[] test = Enumerable.Range(10, 100000000).ToArray();
            //int[] test = { 10, 20, 30, 40 };


            Stopwatch mySearchTimer = new Stopwatch();
            Stopwatch iterativeTimer = new Stopwatch();
            Stopwatch dotNetTimer = new Stopwatch();
            Stopwatch foreachTimer = new Stopwatch();



            dotNetTimer.Start();
            int c = Array.BinarySearch(test, 88888888);
            dotNetTimer.Stop();

            mySearchTimer.Start();
            int a = SortableCollection.BinSearch(88888888, test);
            mySearchTimer.Stop();

            iterativeTimer.Start();
            int d = SortableCollection.BinarySearchIterative(88888888, test);
            iterativeTimer.Stop();

            foreachTimer.Start();
            int b = SortableCollection.LinearSearch(88888888, test);
            foreachTimer.Stop();

            // SortableCollection.Shuffle(test);
            // Console.WriteLine(string.Join(" ",test));


          
            Console.WriteLine(".net search result:{0} time: {1} ", c, dotNetTimer.ElapsedTicks);
            Console.WriteLine("my bin search iterative result:{0} time: {1} ", d, iterativeTimer.ElapsedTicks);
            Console.WriteLine("my bin search recursive result:{0} time: {1}", a, mySearchTimer.ElapsedTicks);
            Console.WriteLine("my iterative search result:{0} time: {1} ", d, foreachTimer.ElapsedTicks);









        }
    }
}
