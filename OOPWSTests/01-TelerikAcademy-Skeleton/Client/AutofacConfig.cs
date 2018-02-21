using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Academy.Core.Providers;
using Academy.Core.Contracts;
using Academy.Core;
using Academy.Core.Factories;
using Academy.Commands.Creating;
using Academy.Commands.Contracts;
using Academy.Commands.Creating.decorator;

namespace Client
{
    public class AutofacConfig: Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {


            builder.RegisterType<ConsoleReader>().As<IReader>();
            builder.RegisterType<ConsoleWriter>().As<IWriter>();
            builder.RegisterType<CommandParser>().As<IParser>();
            builder.RegisterType<Engine>().As<IEngine>();
            builder.RegisterType<AcademyFactory>().As<IAcademyFactory>();
            builder.RegisterType<CommandFactory>().As<ICommandFactory>();
            builder.RegisterType<CreateTrainerCommand>().Named<ICommand>("createtrainer internal");

            builder.RegisterType<CreateTrainerDecorator>().Named<ICommand>("createtrainer")
                .WithParameter((pi,ctx)=>pi.Name=="command", (pi, ctx) => ctx.ResolveNamed<ICommand>("createtrainer internal"));
        }
        
    }
}
