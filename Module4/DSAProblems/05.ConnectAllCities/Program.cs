using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ConnectAllCities
{
    public class City
    {
        private readonly int value;
        public City()
        {
            this.IsVisited = false;
            this.ConnectedTo = new List<City>();
        }
        public List<City> ConnectedTo { get; set; }
        public bool IsVisited { get; set; }
    }
    class Program
    {
        static int timesPrint;
        static City firstCityFromCircle;
        static City secondCityFromCircle;
        static City thirdCityToDetach;
        static City fourthCityToDetach;

        static int nuberOfCities;
        static void Main(string[] args)
        {
            //setup
            int times = int.Parse(Console.ReadLine());
            var dict = new Dictionary<int, City>();
            var sb = new StringBuilder();
            //setting different tests

            for (int i = 0; i < times; i++)
            {
                //setting grapghs
                nuberOfCities = int.Parse(Console.ReadLine());
                for (int k = 0; k < nuberOfCities; k++)
                {
                    dict.Add(k, new City());
                }
                for (int j = 0; j < nuberOfCities; j++)
                {
                    var currentCity = dict[j];
                    var connectionInfo = Console.ReadLine();
                    for (int h = 0; h < nuberOfCities; h++)
                    {
                        if (connectionInfo[h] == '1')
                        {
                            currentCity.ConnectedTo.Add(dict[h]);
                        }
                    }
                }
                if (CheckIfConnected(dict))
                {
                    sb.AppendLine("0");

                    dict.Clear();
                    continue;
                }
                if (!FindCircles(dict))
                {
                    sb.AppendLine("-1");
                    dict.Clear();
                    continue;
                }

                
                while (FindCircles(dict))
                {
                    
                    //it found circles now have to deattach them and try to check again
                    try
                    {
                        firstCityFromCircle.ConnectedTo.Remove(secondCityFromCircle);
                        secondCityFromCircle.ConnectedTo.Remove(firstCityFromCircle);
                        thirdCityToDetach.ConnectedTo.Remove(fourthCityToDetach);
                        fourthCityToDetach.ConnectedTo.Remove(thirdCityToDetach);
                        firstCityFromCircle.ConnectedTo.Add(thirdCityToDetach);
                        thirdCityToDetach.ConnectedTo.Add(firstCityFromCircle);
                        secondCityFromCircle.ConnectedTo.Add(fourthCityToDetach);
                        fourthCityToDetach.ConnectedTo.Add(secondCityFromCircle);
                        timesPrint++;
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("hello"); ;
                    }
                    if (CheckIfConnected(dict))
                    {
                        sb.AppendLine($"{timesPrint}");
                        timesPrint = 0;
                        dict.Clear();
                        continue;
                    }

                    else if (!CheckIfConnected(dict))
                    {
                        if (!FindCircles(dict))
                        {
                            sb.AppendLine("-1");

                        }
                    }
                }
                dict.Clear();
            }
            Console.Write(sb.ToString());

        }
        static bool CheckIfConnected(Dictionary<int, City> grapgh)
        {
            var count = 0;
            var start = grapgh[0];
            start.IsVisited = true;
            var queue = new Queue<City>();
            queue.Enqueue(start);

            while (queue.Any())
            {
                var currentItem = queue.Dequeue();
                count++;
                foreach (var item in currentItem.ConnectedTo)
                {
                    if (!item.IsVisited)
                    {
                        queue.Enqueue(item);
                        item.IsVisited = true;
                    }
                }
            }
            foreach (var item in grapgh.Values)
            {
                item.IsVisited = false;
            }
            if (count == nuberOfCities)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        static bool FindCircles(Dictionary<int, City> grapgh)
        {
            var count = 0;
            var start = grapgh.Values.FirstOrDefault(x => x.ConnectedTo.Count > 1);
            if (start == null)
            {
                return false;
            }
            start.IsVisited = true;
            var queue = new Queue<City>();
            var notSearchingThisCity = new HashSet<City>();
            queue.Enqueue(start);

            while (count != nuberOfCities)
            {
                while (queue.Any())
                {
                    var currentItem = queue.Dequeue();
                    notSearchingThisCity.Add(currentItem);
                    count++;
                    foreach (var item in currentItem.ConnectedTo)
                    {
                        if (!item.IsVisited)
                        {
                            queue.Enqueue(item);
                            item.IsVisited = true;
                        }
                        else if (item.IsVisited && !notSearchingThisCity.Contains(item))
                        {
                            firstCityFromCircle = currentItem;
                            secondCityFromCircle = item;
                            item.IsVisited = true;
                            thirdCityToDetach = grapgh.Values.
                                FirstOrDefault((x => x.IsVisited == false &&
                                x.ConnectedTo.Contains(currentItem) == false &&
                                x.ConnectedTo.Contains(item) == false));
                            if (thirdCityToDetach == null)
                            {
                                return false;
                            }
                            fourthCityToDetach = thirdCityToDetach.ConnectedTo.
                                FirstOrDefault((x => x.IsVisited == false &&
                                x.ConnectedTo.Contains(currentItem) == false &&
                                x.ConnectedTo.Contains(item) == false));
                            if (fourthCityToDetach == null)
                            {
                                return false;
                            }
                            foreach (var city in grapgh.Values)
                            {
                                city.IsVisited = false;
                            }

                            return true;
                        }
                    }
                }
                if (count == nuberOfCities)
                {
                    foreach (var item in grapgh.Values)
                    {
                        item.IsVisited = false;
                    }
                    continue;
                }
                var next = grapgh.Values.First(x => x.IsVisited == false);
                next.IsVisited = true;
                queue.Enqueue(next);
            }
            return false;
        }

    }

}
