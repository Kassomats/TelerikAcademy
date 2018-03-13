using DBData;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new TelerikAcademyEntities();
            CreateDatabaseIfNotExists(context);
            var deps = context.Departments;
            var employees = context.Employees;

            //var persToAdd = new Employee
            //{
            //    FirstName = "marto",
            //    LastName = "peshds2z",
            //    JobTitle = "asdasd",
            //    HireDate = DateTime.Now,
            //    Salary = 5000,
            //    ManagerID = 314
            //};
            //employees.Add(persToAdd);

            //var persTest = employees.ToList().Find(x => x.EmployeeID == 313);
            //employees.Remove(persTest);


            //var depToRemove = deps.ToList().Find(x => x.Employee == 313);
            //deps.Remove(depToRemove);

            context.SaveChanges();
        }
    }
}
