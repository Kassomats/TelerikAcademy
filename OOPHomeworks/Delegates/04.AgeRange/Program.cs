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

            Student gosho1 = new Student("bds", "abds", 17);
            Student gosho2 = new Student("legit", "aew", 18);
            Student gosho3 = new Student("legit", "bdsa", 24);
            Student gosho4 = new Student("afd", "cdsa", 25);

            List<Student> studList = new List<Student>();
            studList.Add(gosho1);
            studList.Add(gosho2);
            studList.Add(gosho3);
            studList.Add(gosho4);
            studList = studList
                .Where(x => x.Age >= 18 && x.Age <= 24)
                .OrderBy(x => x.FirstName)
                .ThenBy(x => x.LastName)
                .ToList();


            foreach (var item in studList)
            {
                Console.WriteLine(item.FirstName+ " "+item.LastName);
            }

            

        }
    }
    public class Student
    {
        private string firstName;
        private string lastName;
        private int age;
        public Student(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public string FirstName { get => firstName; private set => firstName = value; }
        public string LastName { get => lastName; private set => lastName = value; }
        public int Age { get => age; private set => age = value; }
    }
}
