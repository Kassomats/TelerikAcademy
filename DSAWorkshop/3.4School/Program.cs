using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace _3._4School
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfStudents = int.Parse(Console.ReadLine());
            List<Person> theSchool = new List<Person>();
            OrderedBag<BestConnections> bestConns = new OrderedBag<BestConnections>();

            for (int i = 0; i < numOfStudents; i++)
            {
                string name = Console.ReadLine();
                string gender = Console.ReadLine();
                int numOfInterests = int.Parse(Console.ReadLine());
                var interests = Console.ReadLine().Split(',').ToList();

                var personToAdd = new Person(name, gender, interests);
                theSchool.Add(personToAdd);
            }

            for (int i = 0; i < theSchool.Count; i++)
            {
                var currentPerson = theSchool[i];
                var matchedOne = theSchool[i];
                int bestSameInterests = 0;
                for (int ki = i; ki < theSchool.Count; ki++)
                {
                    var tryingToMatch = theSchool[ki];
                    int sameInterests = 0;

                    if (currentPerson.Gender == tryingToMatch.Gender)
                    {
                        continue;
                    }
                    else
                    {
                        foreach (var item in currentPerson.Interests)
                        {
                            foreach (var secondItem in tryingToMatch.Interests)
                            {
                                if (item == secondItem)
                                {
                                    sameInterests++;
                                }
                            }

                        }
                    }
                    if (sameInterests > bestSameInterests)
                    {
                        bestSameInterests = sameInterests;
                        matchedOne = tryingToMatch;
                    }
                }
                if (currentPerson != matchedOne)
                {
                    bestConns.Add(new BestConnections(currentPerson, matchedOne, bestSameInterests));
                }


            }
            var bestConnEver = bestConns[0];
            Console.WriteLine(bestConnEver.ToString());
        }
    }
    public class BestConnections : IComparable<BestConnections>
    {
        public BestConnections(Person firstPerson, Person secondPerson, int numberOfConnections)
        {
            if (firstPerson.Gender == "m")
            {
                FirstPerson = firstPerson;
                SecondPerson = secondPerson;
            }
            else
            {
                SecondPerson = firstPerson;
                FirstPerson = secondPerson;
            }
            NumberOfConnections = numberOfConnections;
        }

        public Person FirstPerson { get; }
        public Person SecondPerson { get; }
        public int NumberOfConnections { get; }

        public int CompareTo(BestConnections other)
        {
            if (this.NumberOfConnections == other.NumberOfConnections)
            {
                return this.FirstPerson.Name.CompareTo(other.FirstPerson.Name);
            }
            else
            {
                return -this.NumberOfConnections.CompareTo(other.NumberOfConnections);
            }
        }

        public override string ToString()
        {
            var text = string.Empty;
            if (FirstPerson.Gender == "m")
            {
                text = $"{FirstPerson.Name} and {SecondPerson.Name} have {NumberOfConnections} common interests!";

            }
            else
            {
                text = $"{SecondPerson.Name} and {FirstPerson.Name} have {NumberOfConnections} common interests!";
            }

            return text;
        }
    }

    public class Person
    {
        public Person(string name, string gender, List<string> interests)
        {
            Name = name;
            Gender = gender;
            Interests = interests;
        }

        public string Name { get; }
        public string Gender { get; }
        public List<string> Interests { get; }
    }
}
