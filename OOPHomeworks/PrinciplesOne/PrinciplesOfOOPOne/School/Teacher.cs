using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Teacher : Person
    {
        private List<Discipline> skill = new List<Discipline>();
        public Teacher(string name) : base(name)
        {
        }

        public List<Discipline> Skill { get => skill; set => skill = value; }

        public void Teach()
        {
            foreach (var item in skill)
            {
                Console.WriteLine("I'm teaching {0}",item.Name);
            }
        }

    
    }
}
