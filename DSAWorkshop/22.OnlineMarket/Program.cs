using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wintellect.PowerCollections;

namespace _06.PlayerRanking
{
    public class Prod : IComparable<Prod>
    {
        public Prod(string name, double price, string type)
        {
            this.Name = name;
            this.Price = price;
            this.Type = type;
        }

        public string Name { get; set; }
        public string Type { get; set; }
        public double Price { get; set; }

        public int CompareTo(Prod second)
        {
            if (this.Price.CompareTo(second.Price) > 0)
            {
                return 1;
            }
            else if (this.Price.CompareTo(second.Price) < 0)
            {
                return -1;
            }
            else if (this.Price.CompareTo(second.Price) == 0)
            {
                if (this.Name.CompareTo(second.Name) > 0)
                {
                    return 1;
                }
                else if (this.Name.CompareTo(second.Name) < 0)
                {
                    return -1;
                }
                else if (this.Name.CompareTo(second.Name) == 0)
                {

                    if (this.Type.CompareTo(second.Type) > 0)
                    {
                        return 11;
                    }
                    else if (this.Type.CompareTo(second.Type) < 0)
                    {
                        return -1;
                    }
                    else if (this.Type.CompareTo(second.Type) == 0)
                    {
                        return 0;
                    }
                }
            }

            return 0;
        }
    }

    class PlayerRanking
    {
        static void Main(string[] args)
        {

            Dictionary<string, OrderedSet<Prod>> playersByTypes = new Dictionary<string, OrderedSet<Prod>>();

            Dictionary<string, Prod> playersByName = new Dictionary<string, Prod>();

            OrderedBag<Prod> playersByPrice = new OrderedBag<Prod>();
            StringBuilder result = new StringBuilder();

            string[] command = Console.ReadLine().Split();

            string name = string.Empty;
            double price = 0;
            string type = string.Empty;

            while (command[0] != "end")
            {
                switch (command[0])
                {
                    case "add":
                        name = command[1];
                        price = double.Parse(command[2]);
                        type = command[3];

                        Prod toAdd = new Prod(name, price, type);

                        if (playersByName.ContainsKey(name))
                        {
                            result.AppendLine($"Error: Product {name} already exists");
                            break;
                        }
                        playersByPrice.Add(toAdd);
                        playersByName.Add(name, toAdd);
                        result.AppendLine($"Ok: Product {name} added successfully");

                        if (playersByTypes.ContainsKey(type))
                        {
                            if (playersByTypes[type].Count >= 10)
                            {
                                var lastPlayer = playersByTypes[type][9];

                                if (lastPlayer.CompareTo(toAdd) > 0)
                                {
                                    playersByTypes[type].RemoveLast();
                                    playersByTypes[type].Add(toAdd);
                                }
                            }
                            else
                            {
                                playersByTypes[type].Add(toAdd);
                            }
                        }
                        else
                        {
                            playersByTypes.Add(type, new OrderedSet<Prod>());
                            playersByTypes[type].Add(toAdd);
                        }

                        break;
                    case "filter":
                       
                        if (command[2] == "type")
                        {
                            if (playersByTypes.ContainsKey(command[3]))
                            {
                                result.Append("Ok: ");
                                foreach (var unit in playersByTypes[command[3]])
                                {
                                    result.Append(unit.Name);
                                    result.Append($"({unit.Price}), ");
                                }
                                if (playersByTypes[command[3]].Count > 0)
                                {
                                    result.Length -= 2;
                                }
                                
                                result.AppendLine();
                            }
                            else if (!playersByTypes.ContainsKey(command[3]))
                            {
                                result.AppendLine($"Error: Type {command[3]} does not exists");
                            }
                        }
                        else if (command.Count() == 7) //from - to
                        {
                            bool changed = false;
                            int count = 0;
                            double from = double.Parse(command[4]);
                            double to = double.Parse(command[6]);
                            result.Append("Ok: ");
                            foreach (var item in playersByPrice)
                            {
                                if (count==10)
                                {
                                    break;
                                }
                                if (item.Price >=from && item.Price<= to)
                                {
                                    result.Append(item.Name);
                                    result.Append($"({item.Price}), ");
                                    count++;
                                    changed = true;
                                }
                                
                            }
                            if (changed)
                            {
                                result.Length -= 2;
                            }
                            
                            result.AppendLine();
                        }
                        else if (command[3]=="from") //from
                        {
                            bool changed = false;

                            int count = 0;
                            double from = double.Parse(command[4]);
                            result.Append("Ok: ");
                            foreach (var item in playersByPrice)
                            {
                                if (count == 10)
                                {
                                    break;
                                }
                                if (item.Price >= from)
                                {
                                    changed = true;
                                    result.Append(item.Name);
                                    result.Append($"({item.Price}), ");
                                    count++;
                                }
                                
                            }
                            if (changed)
                            {
                                result.Length -= 2;
                            }
                            
                            result.AppendLine();
                        }
                        else if (command[3] == "to") //to
                        {
                            bool changed = false;

                            int count = 0;
                            double to = double.Parse(command[4]);
                            result.Append("Ok: ");
                            foreach (var item in playersByPrice)
                            {
                                if (count == 10)
                                {
                                    break;
                                }
                                if (item.Price <= to)
                                {
                                    changed = true;
                                    result.Append(item.Name);
                                    result.Append($"({item.Price}), ");
                                    count++;
                                }
                               
                            }
                            if (changed)
                            {
                                result.Length -= 2;
                            }
                            result.AppendLine();
                        }

                        break;

                }

                command = Console.ReadLine().Split();
            }

            Console.Write(result.ToString());
        }
    }
}
