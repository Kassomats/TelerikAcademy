using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _07.Timer
{
    public delegate void Timer(string str, int times);
    class Program
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer(Printer);
            timer += Greeter;

            timer("hello", 5);
        }


        public static void Printer(string str, int times)
        {
            for (int i = 0; i < times; i++)
            {
                
                Console.WriteLine(str);
                Thread.Sleep(1000);
            }
        }
        public static void Greeter(string str, int timesw)
        {
            for (int i = 0; i < timesw; i++)
            {

                Console.WriteLine(str + "greetings");
                Thread.Sleep(1000);
            }
        }
    }
}
