using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondDSAExamPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int numberEdges = input[0];
            int theWays = input[1];
            List<City> graph = new List<City>();
            List<long> heights = new List<long>();

            for (int i = 1; i <= numberEdges; i++)
            {
                graph.Add(new City(i));
            }

            for (int i = 0; i < theWays; i++)
            {
                var secondInput = Console.ReadLine().Split().ToArray();
                int firstCity = int.Parse(secondInput[0]);
                int secondCity = int.Parse(secondInput[1]);
                long highestTruck = long.Parse(secondInput[2]);

                if (!heights.Contains(highestTruck))
                {
                    heights.Add(highestTruck);
                }
                graph[firstCity - 1].Connections.Add(graph[secondCity - 1], highestTruck);
                graph[secondCity - 1].Connections.Add(graph[firstCity - 1], highestTruck);

            }
            
            heights.Sort();
            
            long bestHeight = long.MinValue;

            for (int i = heights.Count - 1; i > 0; i--)
            {
                bestHeight = heights[i];
                bool allChecked = true;

                DFS(graph[0], bestHeight);

                foreach (var city in graph)
                {
                    if (city.IsChecked == false)
                    {
                        allChecked = false;
                    }
                }

                foreach (var item in graph)
                {
                    item.IsChecked = false;
                }

                if (allChecked)
                {
                    break;
                }
            }


            Console.WriteLine(bestHeight);



        }
        public static void DFS(City currentCity, long height)
        {
            if (currentCity.IsChecked)
            {
                return;
            }
            bool possibleToContinue = false;

            foreach (var item in currentCity.Connections)
            {
                if (item.Value >= height)
                {
                    possibleToContinue = true;
                }
            }
            if (possibleToContinue)
            {
                currentCity.IsChecked = true;
                foreach (var item in currentCity.Connections)
                {
                    DFS(item.Key, height);
                }
            }
           
            return;
        }
    }

    public class City
    {
        private readonly long name;
        Dictionary<City, long> connections = new Dictionary<City, long>();
        bool isChecked = false;

        public City(int name)
        {
            this.name = name;
        }
        public Dictionary<City, long> Connections { get => connections; set => connections = value; }

        public long Name => name;

        public bool IsChecked { get => isChecked; set => isChecked = value; }
    }
}
