using Cosmetics.Cart;
using Cosmetics.Contracts;
using Cosmetics.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.Core.Contracts
{
    public interface ICosmeticsFactory
    {
        ICategory CreateCategory(string name);


        IProduct CreateProduct(string name, string brand, decimal price, string gender);


        IShoppingCart ShoppingCart();


    }
}
