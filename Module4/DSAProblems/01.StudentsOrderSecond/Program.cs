using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.StudentsOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var orders = input[1];
            var people = Console.ReadLine().Split().Select(x => new Person(x)).ToArray();
            var peopleDict = new Dictionary<string, Person>();

            peopleDict.Add(people[0].Name, people[0]);
            people[0].Next = people[1];

            Person current;
            Person prev;
            Person next;

            for (int i = 1; i < people.Length - 1; i++)
            {
                current = people[i];
                prev = people[i - 1];
                next = people[i + 1];
                peopleDict.Add(current.Name, current);
                current.SetPrevious(prev);
                current.SetNext(next);

            }
            peopleDict.Add(people[people.Length - 1].Name, people[people.Length - 1]);
            people[people.Length - 1].Previous = people[people.Length - 2];


            Person firstPerson;
            Person secondPerson;

            for (int i = 0; i < orders; i++)
            {
                var pair = Console.ReadLine().Split();
                firstPerson = peopleDict[pair[0]];
                secondPerson = peopleDict[pair[1]];

                if (firstPerson.Next == secondPerson)
                {
                    continue;
                }
                if (firstPerson.Previous != null)
                {
                    firstPerson.Previous.SetNext(firstPerson.Next);
                }
                if (firstPerson.Next != null)
                {
                    firstPerson.Next.SetPrevious(firstPerson.Previous);
                }
                if (secondPerson.Previous != null)
                {
                    secondPerson.Previous.SetNext(firstPerson);
                }
                firstPerson.SetNext(secondPerson);
                firstPerson.SetPrevious(secondPerson.Previous);
                secondPerson.SetPrevious(firstPerson);
            }
            var currentPerson = people.First(x => x.Previous == null);

            var stringbuilder = new StringBuilder();
            for (int i = 0; i < people.Length; i++)
            {
                stringbuilder.Append(currentPerson.Name).Append(" ");
                currentPerson = currentPerson.Next;
            }
            Console.WriteLine(stringbuilder.ToString());

        }
    }
    public class Person
    {
        private readonly string name;
        public Person(string name)
        {
            this.name = name;
        }
        public Person Next { get; set; }
        public Person Previous { get; set; }

        public string Name => name;


        public void SetNext(Person nextPerson)
        {
            this.Next = nextPerson;
        }
        public void SetPrevious(Person prevPerson)
        {
            this.Previous = prevPerson;
        }
    }
}
