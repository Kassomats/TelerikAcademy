using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeepCopy;

namespace ListShallowCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Person>()
            {
                new Person("gesha"),
                new Person("bobo")
            };

            var secondList = new Person[2];

            list.CopyTo(secondList);

            foreach (var item in secondList)
            {
                item.Name = "CORRECT";
            }

            foreach (var item in list)
            {
                Console.WriteLine(item.Name);
            }

        }
    }
    class Person
    {
        private string name;
        public Person(string name)
        {
            this.name = name;
        }
        public string Name { get; set; }
    }
}
