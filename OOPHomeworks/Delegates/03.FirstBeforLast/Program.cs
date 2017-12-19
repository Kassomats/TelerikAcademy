using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FirstBeforLast
{
    class Program
    {
        static void Main(string[] args)
        {

            Student gosho1 = new Student("bds", "abds");
            Student gosho2 = new Student("bds", "aew");
            Student gosho3 = new Student("afd", "bdsa");
            Student gosho4 = new Student("afd", "cdsa");

            List<Student> studList = new List<Student>();
            studList.Add(gosho1);
            studList.Add(gosho2);
            studList.Add(gosho3);
            studList.Add(gosho4);
            studList = studList
                .Where(x => string.Compare(x.FirstName, x.LastName) < 0)
                .OrderBy(x => x.FirstName)
                .ThenBy(x => x.LastName)
                .ToList();

            foreach (var item in studList)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }

        }
    }
    public class Student
    {
        private string firstName;
        private string lastName;
        public Student(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName { get => firstName; private set => firstName = value; }
        public string LastName { get => lastName; private set => lastName = value; }
    }
}
