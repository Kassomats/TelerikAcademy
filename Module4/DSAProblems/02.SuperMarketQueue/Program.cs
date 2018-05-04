using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace _02.SuperMarketQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            BigList<string> queue = new BigList<string>();
            Dictionary<string, int> nameMatchTime = new Dictionary<string, int>();
            var sb = new StringBuilder();
            while (true)
            {
                {
                    var command = Console.ReadLine().Split();
                    switch (command[0])
                    {

                        case "Append":
                            //Console.WriteLine("OK");
                            sb.AppendLine("OK");
                            queue.Add(command[1]);
                            AddPeopleToMatch(command[1], nameMatchTime);
                            break;
                        case "Insert":
                            var position = int.Parse(command[1]);
                            var name = command[2];
                            if (position > queue.Count)
                            {
                                //Console.WriteLine("Error");
                                sb.AppendLine("Error");
                            }
                            else
                            {
                                queue.Insert(position, name);
                                //Console.WriteLine("OK");
                                sb.AppendLine("OK");
                                AddPeopleToMatch(name, nameMatchTime);
                            }
                            break;
                        case "Find":
                            if (nameMatchTime.ContainsKey(command[1]))
                            {
                                //Console.WriteLine(nameMatchTime[command[1]]);
                                sb.AppendLine(nameMatchTime[command[1]].ToString());
                            }
                            else
                            {
                                //Console.WriteLine(0);
                                sb.AppendLine("0");
                            }
                            break;
                        case "End":
                            Console.WriteLine(sb.ToString());
                            Environment.Exit(0);
                            break;
                        case "Serve":
                            var count = int.Parse(command[1]);
                            if (count > queue.Count)
                            {
                                //Console.WriteLine("Error");
                                sb.AppendLine("Error");

                                break;
                            }
                            else
                            {
                                for (int k = 0; k < count; k++)
                                {
                                    sb.Append($"{ queue[0]} ");
                                    // Console.Write($"{ queue[k]} ");
                                    nameMatchTime[queue[0]]--;
                                    queue.RemoveAt(0);

                                }
                                //Console.WriteLine();
                                sb.AppendLine();
                                //queue.RemoveRange(0, count);
                            }
                            
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        static void AddPeopleToMatch(string name, Dictionary<string, int> nameMatchTime)
        {
            if (!nameMatchTime.ContainsKey(name))
            {
                nameMatchTime.Add(name, 1);
            }
            else
            {
                nameMatchTime[name]++;
            }
        }
    }
}
