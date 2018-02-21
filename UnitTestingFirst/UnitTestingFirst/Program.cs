using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            string testString = "";
            LogAnalyzer test = new LogAnalyzer();
            bool isValid = test.IsValidLogFileName(testString);

            Console.WriteLine(isValid);
        }
    }
    public class LogAnalyzer
    {
        public  bool IsValidLogFileName(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                //throw new ArgumentNullException("shouldn't be null or empty");
            }
            if (!fileName.EndsWith(".SLF",StringComparison.CurrentCultureIgnoreCase))
            {
                return false;
            }
            return true;
        }
    }
}
