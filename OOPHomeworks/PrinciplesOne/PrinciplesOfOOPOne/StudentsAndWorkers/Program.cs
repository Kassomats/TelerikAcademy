using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    class Program
    {
        private static Worker gosho0;

        static void Main(string[] args)
        {
            List<Human> humans = new List<Human>();
            List<Student> goshovci = new List<Student>();
            var gosho0 = new Student("gosho", "goshov", 7);
            var gosho1 = new Student("gosho1", "goshov", 6);
            var gosho2 = new Student("gosho2", "goshov", 5);
            var gosho3 = new Student("gosho3", "goshov", 4);
            var gosho4 = new Student("gosho4", "goshov", 0);
            var gosho5 = new Student("gosho5", "goshov", 3);
            var gosho6 = new Student("gosho6", "goshov", 8);
            var gosho7 = new Student("gosho7", "goshov", 1);
            var gosho8 = new Student("gosho8", "goshov", 2);
            var gosho9 = new Student("gosho9", "goshov", 9);
            goshovci.Add(gosho0);
            goshovci.Add(gosho1);
            goshovci.Add(gosho2);
            goshovci.Add(gosho3);
            goshovci.Add(gosho4);
            goshovci.Add(gosho5);
            goshovci.Add(gosho6);
            goshovci.Add(gosho7);
            goshovci.Add(gosho8);
            goshovci.Add(gosho9);

            goshovci = goshovci.OrderBy(x => x.Grade).ToList();

            foreach (var item in goshovci)
            {
                humans.Add(item); 
            }

            List<Worker> peshovci = new List<Worker>();
            var pesho0 = new Worker("gosho", "peshov", 7, 123);
            var pesho1 = new Worker("gosho1", "peshov", 43436, 324);
            var pesho2 = new Worker("gosho2", "peshov", 5, 23);
            var pesho3 = new Worker("gosho3", "peshov", 43324, 123);
            var pesho4 = new Worker("gosho4", "peshov", 0, 32);
            var pesho5 = new Worker("gosho5", "peshov", 3, 123);
            var pesho6 = new Worker("gosho6", "peshov", 4438, 213);
            var pesho7 = new Worker("gosho7", "peshov", 1, 4356);
            var pesho8 = new Worker("gosho8", "peshov", 2, 346);
            var pesho9 = new Worker("gosho9", "peshov", 439, 456);
            peshovci.Add(pesho0);
            peshovci.Add(pesho1);
            peshovci.Add(pesho2);
            peshovci.Add(pesho3);
            peshovci.Add(pesho4);
            peshovci.Add(pesho5);
            peshovci.Add(pesho6);
            peshovci.Add(pesho7);
            peshovci.Add(pesho8);
            peshovci.Add(pesho9);
            peshovci = peshovci.OrderByDescending(x => x.MoneyPerHour).ToList();
            foreach (var item in peshovci)
            {
                humans.Add(item);
            }

            humans = humans.OrderBy(x => x.FirstName).ThenBy(x => x.LastName).ToList();
            foreach (var item in humans)
            {
                Console.WriteLine(item.FirstName+item.LastName);
            }
        }
    }
}
