using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher firstTeacher = new Teacher("Gosho");
            Discipline math = new Discipline("Math",10,15);
            firstTeacher.Skill.Add(math);
            firstTeacher.Teach();
        }
        public class Person
        {
            private string name;
            public Person(string name)
            {
                this.name = name;
            }
            public string Name { get => name; }
        }
        class Student : Person
        {

            private int uniqueNum;
            public Student(string name, int uniqueNum) : base(name)
            {
                this.UniqueNum = uniqueNum;
            }

            public int UniqueNum { get => uniqueNum; set => uniqueNum = value; }
        }
    }
}
