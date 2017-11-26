using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad5
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder changedText = new StringBuilder();
            while (text.IndexOf("<upcase>") != -1)
            {
                changedText.Append(text.Substring(0, text.IndexOf("<upcase>")));
                text = text.Remove(0, text.IndexOf("<upcase>") + 8);
                changedText.Append(text.Substring(0, text.IndexOf("</upcase>")).ToUpper());
                text = text.Remove(0, text.IndexOf("</upcase>") + 9);
            }
            changedText.Append(text);

            Console.WriteLine(changedText);
        }
    }
}
