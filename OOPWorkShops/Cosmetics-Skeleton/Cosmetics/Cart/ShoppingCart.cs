using Bytes2you.Validation;
using Cosmetics.Contracts;
using Cosmetics.Products;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cosmetics.Cart
{
    public class ShoppingCart:IShoppingCart
    {
        private readonly ICollection<IProduct> productList;

        public ShoppingCart()
        {
            this.productList = new List<IProduct>();
        }

        public ICollection<IProduct> ProductList
        {
            get { return this.productList; }
           
        }

        public void AddProduct(IProduct product)
        {
            if (product == null)
            {
                throw new ArgumentNullException();
            }
            this.productList.Add(product);
        }

        public void RemoveProduct(IProduct product)
        {
            Guard.WhenArgument(product, "does exist").IsNull().Throw();
            productList.Remove(product);
        }

        public bool ContainsProduct(IProduct product)
        {
            Guard.WhenArgument(product, "does exist").IsNull().Throw();

            return productList.Contains(product);
        }

        public decimal TotalPrice()
        {
            return this.productList.Sum(currentProduct => (decimal)currentProduct.Price);
        
        }
    }
}
