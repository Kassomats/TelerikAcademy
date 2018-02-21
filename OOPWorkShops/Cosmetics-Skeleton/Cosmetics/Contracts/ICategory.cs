using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.Contracts
{
    public interface ICategory
    {
        IList<IProduct> Products { get; }

        void AddProduct(IProduct product);

        void RemoveProduct(IProduct product);

        string Print();
    }
}
