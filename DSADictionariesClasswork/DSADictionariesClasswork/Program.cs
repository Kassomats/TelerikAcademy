using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSADictionariesClasswork
{
    class Program
    {
        static void Main(string[] args)
        {
            Person first = new Person(10);
            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("burgas", 5);
            dict.Add("varna", 10);

            dict["varna"] = -5;

            var help = dict.Values;
            
            

            Console.WriteLine(string.Join(" ", dict));
            Console.WriteLine(string.Join(" ", help));
            Console.WriteLine(help.First());      


        }
    }
    public class Person
    {
        private int age;

       
        public Person(int age)
        {
            this.Age = age;
        }

        public int Age { get => age; set => age = value; }
    }
    
}
