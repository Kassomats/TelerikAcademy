using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Models.Furnitures
{
    public class AdjustableChair : Chair, IAdjustableChair
    {

        public AdjustableChair(string model, string materialType, decimal price, decimal height, int numberOfLegs)
            : base(model, materialType, price, height, numberOfLegs)
        {
            this.Type = ChairEnum.Adjustable;
        }

        public void SetHeight(decimal height)
        {
            this.Height = height;
        }
    }
}
