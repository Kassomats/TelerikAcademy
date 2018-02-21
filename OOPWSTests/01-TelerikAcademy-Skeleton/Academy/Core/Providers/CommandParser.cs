using Academy.Commands.Contracts;
using Academy.Core.Contracts;
using Academy.Core.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Academy.Core.Providers
{
    public class CommandParser : IParser
    {
        private readonly ICommandFactory fact;

        public CommandParser(ICommandFactory fact)
        {
            this.fact = fact;
        }

        // Magic, do not touch!
        public ICommand ParseCommand(string fullCommand)
        {
            var commandName = fullCommand.Split(' ')[0];
            var command = fact.CreateCommand(commandName);
            return command;
        }

        // Magic, do not touch!
        public IList<string> ParseParameters(string fullCommand)
        {
            var commandParts = fullCommand.Split(' ').ToList();
            commandParts.RemoveAt(0);

            if (commandParts.Count() == 0)
            {
                return new List<string>();
            }

            return commandParts;
        }

        // Very magic, do not even think about touching!!!
       
    }
}
