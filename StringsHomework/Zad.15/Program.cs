using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad._15
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder fixedText = new StringBuilder();
            while (input.IndexOf("<a href=\"") != -1)
            {
                fixedText.Append(input.Substring(0, input.IndexOf("<a href=\"")));
                input = input.Remove(0, input.IndexOf("<a href=\"") + 9);
                string siteSavior = input.Substring(0, input.IndexOf("\""));
                input = input.Remove(0, input.IndexOf("\"")+2);
              
                string commentSavior = input.Substring(0, input.IndexOf("</a>"));
                fixedText.Append("[").Append(commentSavior).Append("](").Append(siteSavior).Append(")");
                input = input.Remove(0, input.IndexOf("</a>")+4);
            }
            fixedText.Append(input);
            Console.WriteLine(fixedText);
        }
    }
}
