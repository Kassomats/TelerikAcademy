using Academy.Commands.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Commands.Creating.decorator
{
    public class CreateTrainerDecorator : ICommand
    {
        private readonly ICommand command;

        public CreateTrainerDecorator(ICommand command)
        {
            this.command = command;
        }

        public string Execute(IList<string> parameters)
        {
            Console.WriteLine("asdasdasdas");
            return this.command.Execute(parameters);
           
        }
    }
}
