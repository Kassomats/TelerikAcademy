using Bytes2you.Validation;
using Cosmetics.Common;
using Cosmetics.Contracts;
using System;

namespace Cosmetics.Products
{
    public class Shampoo : Product, IShampoo
    {
        private uint milliliters;
        private UsageType usage;

        public Shampoo(string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usage)
            : base(name, brand, price, gender)
        {
            if (milliliters < 0)
            {
                throw new ArgumentException();
            }
            this.milliliters = milliliters;
            this.usage = usage;
        }
        public uint Milliliters => milliliters;
        public UsageType Usage => usage;
        public override string Print()
        {
            return $"#{Name} {Brand}\r\n # Price: ${Price}\r\n # Gender: {Gender}\r\n # Milliliters: {milliliters}\r\n # Usage: {usage}\r\n ===";
        }
    }
}
