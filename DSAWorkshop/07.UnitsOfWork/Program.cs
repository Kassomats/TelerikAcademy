using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wintellect.PowerCollections;

namespace _06.PlayerRanking
{
    public class Unit : IComparable<Unit>
    {
        public string Name { get; set; }
        public int Power { get; set; }
        public string Type { get; set; }


        public Unit(string name, int power, string type)
        {
            this.Name = name;
            this.Power = power;
            this.Type = type;

        }
        public int CompareTo(Unit other)
        {
            if (this.Power.CompareTo(other.Power) > 0)
            {
                return -1;
            }
            else if (this.Power.CompareTo(other.Power) < 0)
            {
                return 1;
            }
            else if (this.Power.CompareTo(other.Power) == 0)
            {
                if (this.Name.CompareTo(other.Name) > 0)
                {
                    return 1;
                }
                else if (this.Name.CompareTo(other.Name) < 0)
                {
                    return -1;
                }
                else if (this.Name.CompareTo(other.Name) == 0)
                {
                    return 0;
                }
            }
            return 0;
        }
    }

    class PlayerRanking
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split();


            Dictionary<string, SortedSet<Unit>> unitsByType = new Dictionary<string, SortedSet<Unit>>();

            Dictionary<string, Unit> unitsByName = new Dictionary<string, Unit>();

            SortedSet<Unit> unitsByPower = new SortedSet<Unit>();
            StringBuilder result = new StringBuilder();

            string name;
            string type;
            int power;

            while (command[0] != "end")
            {
                switch (command[0])
                {

                    case "add":
                        name = command[1];
                        type = command[2];
                        power = int.Parse(command[3]);

                        Unit unitToAdd = new Unit(name, power, type);

                        if (unitsByName.ContainsKey(name))

                        {
                            result.AppendLine(string.Format("FAIL: {0} already exists!", unitToAdd.Name));
                            break;
                        }

                        if (unitsByType.ContainsKey(command[2]))
                        {
                            unitsByType[type].Add(unitToAdd);
                        }
                        else
                        {
                            unitsByType.Add(type, new SortedSet<Unit>());
                            unitsByType[type].Add(unitToAdd);
                        }

                        unitsByPower.Add(unitToAdd);
                        unitsByName.Add(name, unitToAdd);

                        result.AppendLine(string.Format("SUCCESS: {0} added!", unitToAdd.Name));

                        break;
                    case "remove":
                        name = command[1];

                        if (unitsByName.ContainsKey(name))
                        {
                            unitsByPower.Remove(unitsByName[name]);
                            unitsByType[unitsByName[name].Type].Remove(unitsByName[name]);
                            unitsByName.Remove(name);
                            result.AppendLine(string.Format("SUCCESS: {0} removed!", name));
                        }
                        else
                        {
                            result.AppendLine(string.Format("FAIL: {0} could not be found!", name));
                        }

                        break;
                    case "find":
                        type = command[1];
                        result.Append(string.Format("RESULT: "));

                        if (unitsByType.ContainsKey(type) && unitsByType[type].Count > 0)
                        {
                            foreach (var item in unitsByType[type].Take(10))
                            {

                                result.Append(string.Format($"{item.Name}[{type}]({item.Power}), "));
                            }
                            result.Length -= 2;
                            result.AppendLine();
                        }
                        else
                        {
                            result.AppendLine();
                        }

                        break;
                    case "power":
                        int numToShow = int.Parse(command[1]);
                        int counted = 0;
                        result.Append(string.Format("RESULT: "));
                        foreach (var item in unitsByPower)
                        {
                            result.Append(string.Format($"{item.Name}[{item.Type}]({item.Power}), "));

                            counted++;
                            if (counted == numToShow)
                            {
                                break;
                            }

                        }
                        if (counted > 0)
                        {
                            result.Length -= 2;
                        }

                        result.AppendLine();
                        break;
                }
                command = Console.ReadLine().Split();
            }
            Console.WriteLine(result);

        }
    }
}