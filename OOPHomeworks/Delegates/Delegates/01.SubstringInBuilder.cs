using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class SubstringInBuilder
    {
        static void Main(string[] args)
        {
            StringBuilder testString = new StringBuilder();
            testString.Append("Hello Pesho");
            testString.Append("Hello Pesho");
            testString = testString.Substring(3, 5);
            Console.WriteLine(testString);
            
    
        }

    }
    public static class Extenstions
    {
        public static StringBuilder Substring(this StringBuilder strBuilder, int start, int counter)
        {
            string builderInString = strBuilder.ToString().Substring(start, counter);
            StringBuilder returnedStrBuider = new StringBuilder();
            return returnedStrBuider.Append(builderInString);
            
        }
    }
}
