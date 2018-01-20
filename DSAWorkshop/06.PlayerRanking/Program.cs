using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wintellect.PowerCollections;

namespace _06.PlayerRanking
{
    public class Player : IComparable<Player>
    {
        public Player(string name, string type, int age)
        {
            this.Name = name;
            this.Type = type;
            this.Age = age;
        }

        public string Name { get; set; }
        public string Type { get; set; }
        public int Age { get; set; }

        public int CompareTo(Player second)
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
                if (this.Age > second.Age)
                {
                    return -1;
                }
                else if (this.Age < second.Age)
                {
                    return 1;
                }
                else if (this.Age == second.Age)
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
            BigList<Player> rankList = new BigList<Player>();
            Dictionary<string, OrderedSet<Player>> playersByTypes = new Dictionary<string, OrderedSet<Player>>();
            StringBuilder result = new StringBuilder();

            string[] command = Console.ReadLine().Split();

            string name = string.Empty;
            string type = string.Empty;
            int age = new int();
            int position = new int();

            while (command[0] != "end")
            {
                switch (command[0])
                {
                    case "add":
                        name = command[1];
                        type = command[2];
                        age = int.Parse(command[3]);
                        position = int.Parse(command[4]);

                        Player toAdd = new Player(name, type, age);


                        if (playersByTypes.ContainsKey(type))
                        {
                            if (playersByTypes[type].Count >= 5)
                            {
                                var lastPlayer = playersByTypes[type][4];

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
                            playersByTypes.Add(type, new OrderedSet<Player>());
                            playersByTypes[type].Add(toAdd);
                        }

                        //if (playersByTypes[type].Count > 5)
                        //{
                        //    playersByTypes[type].RemoveLast();
                        //}


                        rankList.Insert(position - 1, toAdd);


                        result.AppendLine(string.Format("Added player {0} to position {1}", name, position));

                        break;
                    case "find":
                        type = command[1];

                        StringBuilder sb = new StringBuilder();
                        result.Append(string.Format("Type {0}: ", type));

                        if (playersByTypes.ContainsKey(type))
                        {
                            foreach (var unit in playersByTypes[type])
                            {
                                sb.Append(string.Format("{0}({1}); ", unit.Name, unit.Age));
                            }
                        }
                        result.AppendLine(string.Format(sb.ToString().TrimEnd(' ', ';')));

                        break;
                    case "ranklist":
                        int start = int.Parse(command[1]);
                        int end = int.Parse(command[2]);

                        sb = new StringBuilder();

                        var range = rankList.Range(start - 1, end - start + 1);

                        for (int s = 0; s < range.Count; s++)
                        {
                            sb.Append(string.Format("{0}. {1}({2}); ", start + s, range[s].Name, range[s].Age));
                        }

                        result.AppendLine(string.Format(sb.ToString().TrimEnd(' ', ';')));

                        break;
                }

                command = Console.ReadLine().Split();
            }

            Console.Write(result.ToString());
        }
    }
}
