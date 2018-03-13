using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstTesting.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string JobTitle { get; set; }

        public int DepartmentId { get; set; }
        public int ManagerId { get; set; }

        public DateTime HireDate { get; set; }
        public int Salary { get; set; }
        public int AdressId { get; set; }




    }
}
