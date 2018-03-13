using CodeFirstTesting;
using CodeFirstTesting.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDB
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new CodeFirst();
            context.Employees.Add(new Employee { FirstName = "petko" });
            context.SaveChanges();
        }
    }
}
