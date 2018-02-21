using OlympicGames.Core;
using OlympicGames.Core.Factories;
using OlympicGames.Core.Providers;

namespace OlympicGames
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var ioConsole = new IOWrapper();
            
            var engine = new Engine(
                CommandParser.Instance,
                CommandProcessor.Instance,
                OlympicCommittee.Instance,
                OlympicsFactory.Instance,
                ioConsole
                );

            engine.Run();
        }
    }
}
