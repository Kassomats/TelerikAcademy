using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad12
{



    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string a;
            string b;
            string c;
            a = (text.Substring(0, text.IndexOf(":")));
            text = text.Remove(0, text.IndexOf(":") + 3);
            b = (text.Substring(0, text.IndexOf("/")));
            text = text.Remove(0, text.IndexOf("/"));
            c = text;
            Console.WriteLine("[protocol] = {0}", a);
            Console.WriteLine("[server] = {0}", b);
            Console.WriteLine("[resource] = {0}", c);

        }
    }

}


