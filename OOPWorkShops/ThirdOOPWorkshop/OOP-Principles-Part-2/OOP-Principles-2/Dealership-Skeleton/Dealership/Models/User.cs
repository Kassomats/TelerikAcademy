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
    public class User : IUser
    {
        private IList<Contracts.Vehicle> vehicles;
        private string username;
        private string firstName;
        private string lastName;
        private string password;
        private Role role;

        public User(string username, string firstName, string lastName, string password, string role)
        {
            Guard.WhenArgument(username.Length, "user length").IsLessThan(2).IsGreaterThan(20).Throw();

           
            Guard.WhenArgument(firstName.Length, "first name length").IsLessThan(2).IsGreaterThan(20).Throw();
            this.FirstName = firstName;
            Guard.WhenArgument(lastName.Length, "last name length").IsLessThan(2).IsGreaterThan(20).Throw();
            this.LastName = lastName;
            Guard.WhenArgument(password.Length, "pass  length").IsLessThan(5).IsGreaterThan(30).Throw();
            this.Password = password;
            this.Role = (Role)Enum.Parse(typeof(Role), role);
            this.vehicles = new List<Contracts.Vehicle>();
             Guard.WhenArgument(username.Length, "user length").IsLessThan(2).IsGreaterThan(20).Throw();
            foreach (var item in username)
            {
                if (!Char.IsLetter(item))
                {

                    throw new ArgumentException("invalid symbols");
                }
            }
            this.Username = username;
        }



        public string Username { get => username; set => username = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Password { get => password; set => password = value; }
        public Role Role { get => role; set => role = value; }

        public IList<Contracts.Vehicle> Vehicles { get => vehicles; set => vehicles = value; }

        public void AddComment(IComment commentToAdd, Contracts.Vehicle vehicleToAddComment)
        {
            vehicleToAddComment.Comments.Add(commentToAdd);
        }

        public void AddVehicle(Contracts.Vehicle vehicle)
        {
            this.Vehicles.Add(vehicle);
        }

        public string PrintVehicles()
        {
            StringBuilder strB = new StringBuilder();
            strB.Append
                ($"Username: { Username}, FullName: { FirstName}{ LastName}, Role: { Role}");

            foreach (var item in vehicles)
            {

                strB.Append
                    (
                        $"  { item.Type} Make: { item.Make}  " +
                        $" Model: { item.Model}  " +
                        $"  Wheels: { item.Wheels}" +
                        $"Price: ${ item.Price}" +
                        $"Category / Weight capacity / Seats:");

                if (item is Motorcycle)
                {
                    Motorcycle motor = (Motorcycle)item;
                    strB.Append(motor.Category);
                }
                else if (item is Truck)
                {
                    Truck truck = (Truck)item;
                    strB.Append(truck.WeightCapacity);
                }
                else if (item is Car)
                {
                    Car car = (Car)item;
                    strB.Append(car.Seats);
                };

                strB.Append(
                    $"    --COMMENTS--" +
                    $"    ----------"
                    );

                foreach (var ab in item.Comments)
                {
                    strB.Append(ab.Content);
                    strB.Append(ab.Author);
                    strB.Append($"   ----------");
                   strB.Append($"   --COMMENTS--");
                }
            }
            return strB.ToString();
        }

        public void RemoveComment(IComment commentToRemove, Contracts.Vehicle vehicleToRemoveComment)
        {
            vehicleToRemoveComment.Comments.Remove(commentToRemove);
        }

        public void RemoveVehicle(Contracts.Vehicle vehicle)
        {
            this.Vehicles.Remove(vehicle);
        }
    }
}
