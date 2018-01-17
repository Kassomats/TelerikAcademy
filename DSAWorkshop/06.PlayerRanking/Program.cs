using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wintellect.PowerCollections;

namespace _06.PlayerRanking
{
    public class Player : IComparable<Player>
    {
        public Player(string name, string type, byte age)
        {
            this.Name = name;
            this.Type = type;
            this.Age = age;
        }

        public string Name { get; set; }
        public string Type { get; set; }
        public byte Age { get; set; }

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
            else
            {
                if (this.Age > second.Age)
                {
                    return -1;
                }
                else if (this.Age < second.Age)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }


        }
    }

    class PlayerRanking
    {
        static void Main(string[] args)
        {
            BigList<Player> rankList = new BigList<Player>();
            Dictionary<string, OrderedBag<Player>> playersByTypes = new Dictionary<string, OrderedBag<Player>>();
            
        

            string[] command = Console.ReadLine().Split();

            string name = string.Empty;
            string type = string.Empty;
            byte age = new byte();
            int position = new int();

            while (command[0] != "end")
            {
                switch (command[0])
                {
                    case "add":
                        name = command[1];
                        type = command[2];
                        age = byte.Parse(command[3]);
                        position = int.Parse(command[4]);

                        if (playersByTypes.ContainsKey(type))
                        {
                            playersByTypes[type].Add(new Player(name, type, age));
                            if (playersByTypes[type].Count > 5)
                            {
                                playersByTypes[type].RemoveLast();

                            }
                        }
                        else
                        {
                            playersByTypes.Add(type, new OrderedBag<Player>() { new Player(name, type, age)  });
                           
                        }

                       

                        rankList.Insert(position - 1, new Player(name, type, age));

                        Console.WriteLine($"Added player {name} to position {position}");
                        break;
                    case "find":
                        type = command[1];

                        StringBuilder sb = new StringBuilder();

                        Console.Write("Type {0}: ", type);
                        if (playersByTypes.ContainsKey(type))
                        {
                        foreach (var unit in playersByTypes[type])
                        {
                            sb.Append(string.Format($"{unit.Name}({unit.Age}); "));
                        }
                        Console.Write(sb.ToString().TrimEnd(';', ' '));
                        }
                        Console.WriteLine();

                        break;
                    case "ranklist":
                        int start = int.Parse(command[1]);
                        int end = int.Parse(command[2]);

                        sb = new StringBuilder();

                        for (int s = start - 1; s < end; s++)
                        {
                            sb.Append(string.Format($"{s + 1}. { rankList[s].Name}({rankList[s].Age}); "));

                        }
                        Console.WriteLine(sb.ToString().TrimEnd(';', ' '));

                        break;
                }
                command = Console.ReadLine().Split();
            }


        }
    }
}
