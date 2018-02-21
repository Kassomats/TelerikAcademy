using Bytes2you.Validation;
using Dealership.Common.Enums;
using Dealership.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dealership.Models
{
    public class Motorcycle:Vehicle,IMotorcycle
    {
        private string category;
      


        public Motorcycle(string make, string model, decimal price, string category) : base(make, model, price)
        {
            this.Category = category;
        }

        public string Category
        {
            get => category;
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                Guard.WhenArgument(value.Length, "category length").IsLessThan(1).IsGreaterThan(10).Throw();
                this.category = value;
            }
        }

        public override int Wheels { get => wheels; set => wheels = 2; }
        public override VehicleType Type { get => type; set => type = VehicleType.Motorcycle; }
        public override IList<IComment> Comments { get => comments; set => comments = value; }
    }
}
