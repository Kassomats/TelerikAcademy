using Bytes2you.Validation;
using Cosmetics.Products;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cosmetics.Cart
{
    public class ShoppingCart
    {
        private readonly ICollection<Product> productList;

        public ShoppingCart()
        {
            this.productList = new List<Product>();
        }

        public ICollection<Product> ProductList
        {
            get { return this.productList; }
           
        }

        public void AddProduct(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException();
            }
            this.productList.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            Guard.WhenArgument(product, "does exist").IsNull().Throw();
            productList.Remove(product);
        }

        public bool ContainsProduct(Product product)
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
