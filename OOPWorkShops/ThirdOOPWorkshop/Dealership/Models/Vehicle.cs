using Dealership.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dealership.Common.Enums;
using Bytes2you.Validation;

namespace Dealership.Models
{
    public abstract class Vehicle : Contracts.Vehicle
    {
        private string make;
        private string model;
        private decimal price;
        protected int wheels;
        protected VehicleType type;
        protected IList<IComment> comments;

        public Vehicle(string make, string model, decimal price)
        {
            this.Make = make;
            this.Model = model;
            this.Price = price;
        }



        public string Make
        {
            get { return this.make; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                Guard.WhenArgument(value.Length, "make name").IsLessThan(2).IsGreaterThan(15).Throw();
                this.make = value;
            }
        }
        public string Model
        {
            get { return this.model; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                Guard.WhenArgument(value.Length, "model name").IsLessThan(2).IsGreaterThan(15).Throw();
                this.model = value;
            }
        }
        public decimal Price
        {
            get { return this.price; }
            set
            {

                Guard.WhenArgument(value, "price negative").IsLessThan(0).IsGreaterThan(100000).Throw();
                this.price = value;
            }
        }

        public virtual int Wheels { get => wheels; set => wheels = value; }
        public virtual VehicleType Type { get => type; set => type = value; }
        public virtual IList<IComment> Comments { get => comments; set => comments = value; }


    }
}
