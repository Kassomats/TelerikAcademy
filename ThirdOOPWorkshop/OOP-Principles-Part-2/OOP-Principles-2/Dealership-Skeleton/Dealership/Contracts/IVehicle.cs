namespace Dealership.Contracts
{
    using Dealership.Common.Enums;

    public interface Vehicle : ICommentable, IPriceable
    {
        int Wheels { get; }

        VehicleType Type { get; }

        string Make { get; }

        string Model { get; }
    }
}
