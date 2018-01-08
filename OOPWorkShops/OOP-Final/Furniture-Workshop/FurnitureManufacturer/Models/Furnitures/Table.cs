using Bytes2you.Validation;
using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Models.Furnitures
{
    public class Table : Furniture, ITable
    {
        private decimal length;
        private decimal width;
        public Table(string model, string materialType, decimal price, decimal height, decimal length, decimal width)
            : base(model, materialType, price, height)
        {
            this.Length = length;
            this.Width = width;
        }
        public void SetHeight(decimal height)
        {
            this.Height = height;
        }
        public decimal Length { get => length; set => length = value; }
        public decimal Width { get => width; set => width = value; }
        public decimal Area { get => Width * Length; }
        protected override string AdditionalInfo()
        {
            var helpStr = $"Length: {this.Length}, Width: {this.Width}, Area: {this.Area}";
            return helpStr;
        }

    }
}
