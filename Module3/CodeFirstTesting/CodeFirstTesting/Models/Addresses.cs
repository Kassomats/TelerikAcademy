using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstTesting.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string AdressText { get; set; }
        public int? TownId { get; set; }
    }
}
