using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Models.Furnitures
{
    public class ConvertibleChair : Chair, IConvertibleChair
    {
        private decimal oldH;
        public ConvertibleChair(string model, string materialType, decimal price, decimal height, int numberOfLegs)
            : base(model, materialType, price, height, numberOfLegs)
        {
            this.Type = ChairEnum.Convertible;
            oldH = height;
        }
        

        private bool isConverted = false;

        public bool IsConverted { get => isConverted; private set => isConverted = value; }
        

        public void Convert()
        {
            
            if (IsConverted == false)
            {
                IsConverted = true;
                this.Height = 0.10m;
            }
            else if (IsConverted == true)
            {
                IsConverted = false;
                this.Height = oldH;
            }
        }
    }
}
