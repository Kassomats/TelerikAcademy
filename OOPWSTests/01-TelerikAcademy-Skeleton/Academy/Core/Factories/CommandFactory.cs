using Academy.Core.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Commands.Contracts;
using Autofac;

namespace Academy.Core.Providers
{
    public class CommandFactory : ICommandFactory
    {
        private readonly ILifetimeScope container;

        public ICommand CreateCommand(string commandName)
        {
            return this.container.ResolveNamed<ICommand>(commandName);
        }
        public CommandFactory(ILifetimeScope container)
        {
            this.container = container;
        }
    }
}
