using System;

using OlympicGames.Core.Contracts;
using OlympicGames.Core.Factories;
using OlympicGames.Core.Providers;

namespace OlympicGames.Core
{
    public class Engine : IEngine
    {
        private readonly ICommandParser parser;
        private readonly ICommandProcessor commandProcessor;
        private readonly IOlympicsFactory factory;
        private readonly IOlympicCommittee committee;
        private readonly IIOWrapper fakeCons;

        private const string Delimiter = "####################";

        public Engine(
            ICommandParser commandParser,
            ICommandProcessor commandProcessor,
            IOlympicCommittee committee,
            IOlympicsFactory factory,
            IIOWrapper fakeConsole
            )
        {
            this.parser = commandParser;
            this.commandProcessor = commandProcessor;
            this.factory = factory;
            this.committee = committee;
            this.fakeCons = fakeConsole;
        }

        public void Run()
        {
            string commandLine = null;

            while ((commandLine = fakeCons.ReadLine() ) != "end")
            {
                try
                {
                    var command = this.parser.ParseCommand(commandLine);
                    if (command != null)
                    {
                        //this.commandProcessor.Add(command);
                        this.commandProcessor.ProcessSingleCommand(command);
                        fakeCons.WriteLine(Delimiter);
                    }
                }
                catch (Exception ex)
                {
                    while (ex.InnerException != null)
                    {
                        ex = ex.InnerException;
                    }

                    Console.WriteLine("ERROR: {0}", ex.Message);
                }
            }
        }

        
    }
}
