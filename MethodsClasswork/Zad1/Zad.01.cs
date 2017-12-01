using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            string helloToMe = "hello there";
            Console.WriteLine(helloToMe);
            string upperedText = Transformer(helloToMe);
            Console.WriteLine(upperedText);

        }
        static string Transformer(string text)
        {
            return text.ToUpper() ;
            
        }

    }
}
