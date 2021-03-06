﻿using Bytes2you.Validation;
using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Models.Furnitures
{
    // Finish the class
    public abstract class Furniture : IFurniture
    {
        private  string model;
        private  string material;
        private  decimal price;
        private decimal height;

        public Furniture(string model, string materialType, decimal price, decimal height)
        {
            

            Guard.WhenArgument(model, "Model").IsNull().Throw();
            Guard.WhenArgument(model.Length, "Model length").IsLessThan(3).Throw();
            Guard.WhenArgument(materialType, "Material type").IsNull().Throw();
            Guard.WhenArgument(price, "Price cannot be less than zero").IsLessThan(0).Throw();
            Guard.WhenArgument(height, "Height cannot be less than zero").IsLessThan(0).Throw();

            this.model = model;
            this.material = materialType;
            this.price = price;
            this.height = height;
        }

        public string Model => this.model;

        public string Material => this.material;

        public decimal Price => this.price;

        public decimal Height
        {
            get
            {
                return this.height;
            }
            protected set
            {
                this.height = value;
            }
        }


        protected virtual string AdditionalInfo()
        {
            return string.Empty;
        }

        public override string ToString()
        {
            return $"Type: {this.GetType().Name}, Model: {this.Model}, Material: {this.Material}, Price: {this.Price}, Height: {this.Height.ToString("0.00")}, {this.AdditionalInfo()}\r\n";
        }
    }
}
