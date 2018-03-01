using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;
using System.IO;
using Newtonsoft.Json;

namespace JsonTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            var json = File.ReadAllText("../../Doc/movies.json");
            var movies = JsonConvert.DeserializeObject<List<Movie>>(json);
            var orderedActors = movies.SelectMany(movie => movie.Cast).OrderBy(x => x);
            Console.WriteLine(string.Join("\n", orderedActors));
        }
    }
    public class Movie
    {
        public List<string> Cast { get; set; }
    }
}
