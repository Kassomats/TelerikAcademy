using Bytes2you.Validation;
using Cosmetics.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.Products
{
    public abstract class Product
    {
        private string name;
        private string brand;
        private decimal price;
        private GenderType gender;

        public Product(string name, string brand, decimal price, GenderType gender)
        {
            if (name == null || brand == null)
            {
                throw new ArgumentNullException();
            }
            Guard.WhenArgument(name.Length, "name length").IsLessThan(3).IsGreaterThan(10).Throw();

            this.Name = name;
            Guard.WhenArgument(brand.Length, "brand length").IsLessThan(2).IsGreaterThan(10).Throw();

            this.Brand = brand;
            Guard.WhenArgument(price, "price negative").IsLessThan(0).Throw();
            this.Price = price;

            this.Gender = gender;
        }

        public string Name { get => name; private set => name = value; }
        public string Brand { get => brand; private set => brand = value; }
        public decimal Price { get => price; private set => price = value; }
        public GenderType Gender { get => gender; private set => gender = value; }

        public virtual string Print()
        {
            return $"#{name} {brand}\r\n # Price: ${price}\r\n # Gender: {gender}\r\n";
        }
    }
}
