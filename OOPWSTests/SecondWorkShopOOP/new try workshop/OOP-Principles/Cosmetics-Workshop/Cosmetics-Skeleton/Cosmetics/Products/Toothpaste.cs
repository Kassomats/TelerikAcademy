using Bytes2you.Validation;
using Cosmetics.Common;
using Cosmetics.Contracts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Cosmetics.Products
{
    public class Toothpaste : Product, IToothpaste
    {
        private string ingredients;

        public Toothpaste(string name, string brand, decimal price, GenderType gender, string ingredients)
            : base(name, brand, price, gender)
        {

            if (ingredients == null)
            {
                throw new ArgumentNullException();
            }
            this.ingredients = ingredients;
        }
        public string Ingredients => ingredients;
        public override string Print()
        {
            return base.Print() + $" # Ingredients: {ingredients}\r\n ===";
        }
    }
}