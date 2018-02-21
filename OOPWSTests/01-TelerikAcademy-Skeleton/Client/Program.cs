using Academy.Core.Contracts;
using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule<AutofacConfig>();

            var container = builder.Build();
            var engine = container.Resolve<IEngine>();
            engine.Start();

        }
    }
}
