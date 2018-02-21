using Cosmetics.Cart;
using Cosmetics.Common;
using Cosmetics.Contracts;
using Cosmetics.Core.Contracts;
using Cosmetics.Products;
using System;

namespace Cosmetics.Core.Engine
{
    public class CosmeticsFactory: ICosmeticsFactory
    {
        public ICategory CreateCategory(string name)
        {
            return new Category(name);
        }

        public IProduct CreateProduct(string name, string brand, decimal price, string gender)
        {


            GenderType MyStatus = (GenderType)Enum.Parse(typeof(GenderType), gender);

            return new Product(name, brand, price, MyStatus);
        }

        public IShoppingCart ShoppingCart()
        {
            return new ShoppingCart();
        }
    }
}
