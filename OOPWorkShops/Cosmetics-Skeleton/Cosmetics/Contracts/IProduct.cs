using Cosmetics.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.Contracts
{
    public interface IProduct
    {
         decimal Price { get; }

         string Name { get; }

         string Brand { get; }

         GenderType Gender { get; }

         string Print();
    }
}
