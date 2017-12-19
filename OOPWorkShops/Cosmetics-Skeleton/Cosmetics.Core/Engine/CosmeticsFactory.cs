using Cosmetics.Cart;
using Cosmetics.Common;
using Cosmetics.Products;
using System;

namespace Cosmetics.Core.Engine
{
    public class CosmeticsFactory
    {
        public Category CreateCategory(string name)
        {
            return new Category(name);
        }

        public Product CreateProduct(string name, string brand, decimal price, string gender)
        {


            GenderType MyStatus = (GenderType)Enum.Parse(typeof(GenderType), gender);

            return new Product(name, brand, price, MyStatus);
        }

        public ShoppingCart ShoppingCart()
        {
            return new ShoppingCart();
        }
    }
}
