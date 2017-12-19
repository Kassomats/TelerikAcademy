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
    public class Truck: Vehicle , ITruck
    {
        private int weightCapacity;

        public Truck(string make, string model, decimal price, int weightCapacity): base(make, model, price)
        {
            this.WeightCapacity = weightCapacity;
        }
        
        public int WeightCapacity
        {
            get => weightCapacity;
            set
            {
                Guard.WhenArgument(value, "capacity ").IsLessThan(0).IsGreaterThan(100).Throw();
                weightCapacity = value;
            }
        }
        public override int Wheels { get => wheels; set => wheels = 8; }
        public override VehicleType Type { get => type; set => type = VehicleType.Truck; }
        public override IList<IComment> Comments { get => comments; set => comments = value; }
    }
}
