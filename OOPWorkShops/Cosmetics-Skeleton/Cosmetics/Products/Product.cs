using Bytes2you.Validation;
using Cosmetics.Common;
using Cosmetics.Contracts;
using System;

namespace Cosmetics.Products
{
    public class Product:IProduct
    {
        private readonly decimal price;
        private readonly string name;
        private readonly string brand;
        private readonly GenderType gender;
       

        public Product(string name, string brand, decimal price, GenderType gender)
        {
            Guard.WhenArgument(name.Length, "name length").IsLessThan(3).Throw();
            Guard.WhenArgument(name.Length, "name length").IsGreaterThan(10).Throw();
            this.name = name;
            Guard.WhenArgument(brand.Length, "brand length").IsLessThan(2).Throw();
            Guard.WhenArgument(brand.Length, "brand length").IsGreaterThan(10).Throw();
            this.brand = brand;
            Guard.WhenArgument(price, "price").IsLessThan(0).Throw();
            this.price = price;
            
          
            this.gender = gender;         
        }

   

        public decimal Price => price;

        public string Name => name;

        public string Brand => brand;

        public GenderType Gender => gender;

        public string Print()
        {
            return $" #{this.Name} {this.Brand}\r\n #Price: ${this.Price}\r\n #Gender: {this.Gender}\r\n ===";
        }
    }
}
