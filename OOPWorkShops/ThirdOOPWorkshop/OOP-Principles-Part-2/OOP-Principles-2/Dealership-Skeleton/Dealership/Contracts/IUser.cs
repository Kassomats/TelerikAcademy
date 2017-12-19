using Dealership.Common.Enums;
using System.Collections.Generic;

namespace Dealership.Contracts
{
    public interface IUser
    {
        string Username { get; }

        string FirstName { get; }

        string LastName { get; }

        string Password { get; }

        Role Role { get; }

        IList<Vehicle> Vehicles { get; }

        void AddVehicle(Vehicle vehicle);

        void RemoveVehicle(Vehicle vehicle);

        void AddComment(IComment commentToAdd, Vehicle vehicleToAddComment);

        void RemoveComment(IComment commentToRemove, Vehicle vehicleToRemoveComment);

        string PrintVehicles();
    }
}
