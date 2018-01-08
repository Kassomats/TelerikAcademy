using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Models.Furnitures
{
    public class Chair : Furniture, IChair
    {
        private int numberOfLegs;
        private ChairEnum type;
        public Chair(string model, string materialType, decimal price, decimal height, int numberOfLegs)
            : base(model, materialType, price, height)
        {
            this.NumberOfLegs = numberOfLegs;
            this.Type = ChairEnum.Normal;
        }
        public int NumberOfLegs { get => numberOfLegs; set => numberOfLegs = value; }
        public ChairEnum Type { get => type; set => type = value; }
        protected override string AdditionalInfo()
        {
            var helpStr =$"Legs {this.NumberOfLegs}";
            return helpStr;
        }
    }
}
