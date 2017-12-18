using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Discipline
    {
        private string name;
        private int lecturesNum;
        private int excesisesNum;
        public Discipline(string name, int lecturesNum, int excesisesNum)
        {
            this.Name = name;
            this.LecturesNum = lecturesNum;
            this.ExcesisesNum = excesisesNum;
        }

        public string Name { get => name; set => name = value; }
        public int LecturesNum { get => lecturesNum; set => lecturesNum = value; }
        public int ExcesisesNum { get => excesisesNum; set => excesisesNum = value; }
    }
}
