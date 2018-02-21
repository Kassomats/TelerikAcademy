using Autofac;
using Cosmetics.Cart;
using Cosmetics.Contracts;
using Cosmetics.Core.Contracts;
using Cosmetics.Core.Engine;
using Cosmetics.Products;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;

namespace Cosmetics
{
    public class CosmeticsProgram
    {
        public static void Main()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<CosmeticsFactory>().As<ICosmeticsFactory>();
            builder.RegisterType<ShoppingCart>().As<IShoppingCart>();

            builder.RegisterType<Dictionary<string, Category>>().As<IDictionary<string, ICategory>>();
            builder.RegisterType<Dictionary<string, Product>>().As<IDictionary<string, IProduct>>();

            builder.RegisterType<CosmeticsEngine>().As<IEngine>();
            var container = builder.Build();

            var engine = container.Resolve<IEngine>();
            engine.Start();
            //CosmeticsEngine().Start();
        }
    }
}
