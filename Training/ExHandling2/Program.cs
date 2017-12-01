using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExHandling2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int previousValue = 0;
                List<int> array = new List<int>();
                array.Add(1);
                for (int i = 0; i < 10; i++)
                {

                    int a = int.Parse(Console.ReadLine());

                    if (previousValue < a && a > 1)
                    {
                        array.Add(a);
                        previousValue = a;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                array.Add(100);
                Console.Write(array[0]);
                for (int i = 1; i < array.Count; i++)
                {
                    Console.Write(" < " + array[i]);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Exception");
            }
        }
    }
}
