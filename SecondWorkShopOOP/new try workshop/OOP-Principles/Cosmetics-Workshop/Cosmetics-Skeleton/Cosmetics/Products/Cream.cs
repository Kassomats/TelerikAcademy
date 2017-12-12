using Bytes2you.Validation;
using Cosmetics.Common;
using Cosmetics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.Products
{
    public class Cream: ICream
    {
        private string name;
        private string brand;
        private decimal price;
        private GenderType gender;
        private ScentType scent;
        public Cream(string name, string brand, decimal price, GenderType gender, ScentType scent)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Gender = gender;
            this.Scent = scent;
        }
        public string Name
        {
            get { return this.name; }
            set
            {
                Guard.WhenArgument(value.Length, "name wrong").IsLessThan(3).IsGreaterThan(15).Throw();
                this.name = value;
            }
        }
        public string Brand

        {
            get { return this.brand; }
            set
            {
                Guard.WhenArgument(value.Length, "brand wrong").IsLessThan(3).IsGreaterThan(15).Throw();
                this.brand = value;
            }
        }
        public decimal Price
        {
            get { return this.price; }
            set
            {
                Guard.WhenArgument(value, "price wrong").IsLessThan(0).Throw();
                this.price = value;
            }
        }
        public GenderType Gender { get => gender; set => gender = value; }
        public ScentType Scent { get => scent; set => scent = value; }
        public string Print()
        {
            return $"{Brand} {Name}\r\n # Price: ${Price}\r\n # Gender: {Gender}\r\n # Scent: {Scent}\r\n ===";
        }
    }
}