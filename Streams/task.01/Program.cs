using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task._01
{
    class Program
    {
        static int[] testArr = { 1, 2, 3, 4 };

        static void Main(string[] args)
        {
            int[] array = { 10,20,30,40};
            int[] secondArr = { 100,200,300,400};
            ZeroIndexChanger(array);
            Console.WriteLine(array[0]);
            Console.WriteLine(secondArr[0]);
            Console.WriteLine(testArr[0]);


        }
        static void ZeroIndexChanger(int[] arrChanger)
        {
            arrChanger[0] = 5;
            testArr[0] = 4;
        }
    }
}
