using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    delegate void MyDelegate(string a);

    class Program
    {
        static void Main(string[] args)
        {
            var input = "Petko";
            Func<string, string> test = FirstMethod;
            test += SecondMethod;

            var myList = new List<string> { "marto", "chefichacold", "petko", "ochite" };
            Expression<Func<string, string>> exp = x => x + x ;
        }


        static string FirstMethod(string input)
        {
            return input + " firstMethid";
        }
        static string SecondMethod(string input)
        {
            return input + " secondMethid";

        }
    }
}
