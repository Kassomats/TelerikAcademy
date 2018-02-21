using Bytes2you.Validation;
using Cosmetics.Contracts;
using Cosmetics.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cosmetics
{
    public class Category:ICategory
    {
        private readonly string name;
        private readonly IList<IProduct> products;

        public Category(string name)
        {
            Guard.WhenArgument(name, "category name").IsNull().Throw();
            Guard.WhenArgument(name.Length, "category name length").IsLessThan(3).Throw();
            Guard.WhenArgument(name.Length, "category name length").IsGreaterThan(15).Throw();
            this.name = name;
            this.products = new List<IProduct>();
           
        }

        public IList<IProduct> Products
        {
            get
            {
                return this.products;
            }
        }

        public virtual void AddProduct(IProduct product)
        {
            Guard.WhenArgument(product, "does exist").IsNull().Throw();
            products.Add(product);

        }

        public virtual void RemoveProduct(IProduct product)
        {
            if (!products.Remove(product))
                throw new ArgumentNullException();
        }

        public string Print()
        {
            var strBuilder = new StringBuilder();

            foreach (var product in this.products)
            {
                strBuilder.AppendLine(product.Print());
            }
            if (strBuilder.Capacity == 0)
            {
                return "No product in shopping cart!";
            }
            else
            {
                return $"#{strBuilder}";
            }
        }
    }
}
