using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new MyWriter();
            MyWriter.Writer();
            //a.WriterNonStatic();
        }
    }
    class MyWriter
    {
        //you can call static methods in nonstatic ones 
        //but you cant call nonstatic methods in static ones
        int tester = 5;
        public static void Writer()
        {
            var a = new MyWriter();
            a.WriterNonStatic();
            Console.WriteLine("static writer here");

        }
        public void WriterNonStatic()
        {
            Console.WriteLine(tester);
            Console.WriteLine("nonstatic writer here");
        }
    }
}
