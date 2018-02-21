using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympicGames.Core.Providers
{
    class IOWrapper : IIOWrapper
    {
        private readonly IWriter writer;
        private readonly IReader reader;

        public IOWrapper(IWriter writer, IReader reader)
        {
            this.writer = writer;
            this.reader = reader;
        }
        public string ReadLine()
        {
            return reader.ReadLine();
        }

        public void WriteLine(string text)
        {
            writer.WriteLine(text);
        }
    }
}
