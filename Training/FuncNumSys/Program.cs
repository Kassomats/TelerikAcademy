using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncNumSys
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(new string[] { ", "}, StringSplitOptions.None).ToArray();
            int a = GiveMeNumber(array[0]);
            int b = GiveMeNumber(array[1]);
            int c = GiveMeNumber(array[2]);
            Console.WriteLine("{0} {1} {2}", a, b, c);
        }
        static int GiveMeNumber(string input)
        {
            int helper = 0;
            switch (input)
            {
                case "ocaml":
                    helper = 0;
                    break;
                case "haskell":
                    helper = 1;
                    break;
                case "scala":
                    helper = 2;
                    break;
                case "f#":
                    helper = 3;
                    break;
                case "lisp":
                    helper = 4;
                    break;
                case "rust":
                    helper = 5;
                    break;
                case "ml":
                    helper = 6;
                    break;
                case "clojure":
                    helper = 7;
                    break;
                case "erlang":
                    helper = 8;
                    break;
                case "standardml":
                    helper = 9;
                    break;
                case "racket":
                    helper = 10;
                    break;
                case "elm":
                    helper = 11;
                    break;
                case "mercury":
                    helper = 12;
                    break;
                case "commonlisp":
                    helper = 13;
                    break;
                case "scheme":
                    helper = 14;
                    break;
                case "curry":
                    helper = 15;
                    break;
            }
            return helper;
        }
    }
}
