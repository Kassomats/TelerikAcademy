using Bytes2you.Validation;
using Dealership.Common.Enums;
using Dealership.Contracts;
using System.Collections.Generic;

namespace Dealership.Models
{
    public class Car : Vehicle, ICar
    {
        private int seats;
        
        public Car(string make, string model, decimal price, int seats) : base(make, model, price)
        {
            this.Seats = seats;
        }
        public int Seats
        {
            get
            {
                return this.seats;
            }
            set
            {
                Guard.WhenArgument(value, "seats").IsLessThan(0).IsGreaterThan(10).Throw();
                this.seats = value;
            }
        }
        public override int Wheels { get => wheels; set => wheels = 4; }
        public override VehicleType Type { get => type; set => type = VehicleType.Car; }
        public override IList<IComment> Comments { get => comments; set => comments = value; }
    }
}
