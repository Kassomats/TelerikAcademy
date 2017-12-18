using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    class Worker : Human
    {
        private int salary;
        private int hrsPerDay;

        public Worker(string firstName, string lastName, int salary, int hrsPerDay) : base(firstName, lastName)
        {
            this.Salary = salary;
            this.HrsPerDay = hrsPerDay;
        }

        public int Salary { get => salary; set => salary = value; }
        public int HrsPerDay
        {
            get => hrsPerDay;
            set => hrsPerDay = value;
        }
        
        public decimal MoneyPerHour  => (decimal) salary / hrsPerDay* 8;
    }
}
