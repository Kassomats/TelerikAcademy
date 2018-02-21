using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace _3._2OrderSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bag bagOfOrders = new Bag<Order>();

            var dictOrdersByCustomers = new Dictionary<string, OrderedBag<Order>>();
            var numOfCommands = int.Parse(Console.ReadLine());
            var bagOfAllItems = new Bag<Order>();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < numOfCommands; i++)
            {

                var command = Console.ReadLine();
                //AddOrder name; price; consumer
                if (command.StartsWith("AddOrder"))
                {
                    var newCommands = command.Replace("AddOrder ", "").Trim();

                    var orderInfo = newCommands.Split(';').ToArray();
                    var name = orderInfo[0];
                    var price = double.Parse(orderInfo[1]);
                    var consumer = orderInfo[2];
                    var order = new Order(name, price, consumer);
                    bagOfAllItems.Add(order);

                    if (!dictOrdersByCustomers.ContainsKey(consumer))
                    {
                        dictOrdersByCustomers.Add(consumer, new OrderedBag<Order>());
                    }
                    dictOrdersByCustomers[consumer].Add(order);
                    sb.AppendLine("Order added");
                }

                else if (command.StartsWith("DeleteOrders"))
                {

                    var name = command.Replace("DeleteOrders ", "").Trim();

                    if (!dictOrdersByCustomers.ContainsKey(name))
                    {
                        sb.AppendLine("No orders found");
                    }
                    else
                    {
                        sb.AppendLine($"{dictOrdersByCustomers[name].Count} orders deleted");
                        foreach (var item in dictOrdersByCustomers[name])
                        {
                            bagOfAllItems.Remove(item);
                        }
                        dictOrdersByCustomers.Remove(name);

                    }
                }

                else if (command.StartsWith("FindOrdersByConsumer"))
                {

                    var name = command.Replace("FindOrdersByConsumer ", "").Trim();

                    if (!dictOrdersByCustomers.ContainsKey(name))
                    {
                        sb.AppendLine("No orders found");
                    }
                    else
                    {
                        foreach (var item in dictOrdersByCustomers[name])
                        {
                            sb.AppendLine(item.ToString());
                        }
                    }
                }
                //FindOrdersByPriceRange fromPrice; toPrice
                else if (command.StartsWith("FindOrdersByPriceRange"))
                {
                    var bagByPrice = new OrderedBag<Order>();
                    var name = command.Replace("FindOrdersByPriceRange ", "").Trim();
                    var splittedCommand = name.Split(';').ToArray();

                    var under = double.Parse(splittedCommand[0]);
                    var over = double.Parse(splittedCommand[1]);
                    foreach (var item in bagOfAllItems)
                    {
                        if (item.Price >= under && item.Price <= over)
                        {
                            bagByPrice.Add(item);
                        }
                    }
                    if (bagByPrice.Count == 0)
                    {
                        sb.AppendLine("No orders found");
                    }
                    else
                    {
                        foreach (var item in bagByPrice)
                        {
                            sb.AppendLine(item.ToString());
                        }
                        bagByPrice.Clear();
                    }

                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
    class Order : IComparable<Order>
    {
        public Order(string itemName, double price, string consumer)
        {
            ItemName = itemName;
            Price = price;
            Consumer = consumer;
        }

        public string ItemName { get; }
        public double Price { get; }
        public string Consumer { get; }

        public int CompareTo(Order other)
        {
            return this.ItemName.CompareTo(other.ItemName);
        }

        public override string ToString()
        {
            var text = "{" + $"{ItemName};{Consumer};{Price:F2}" + "}";
            return text;
        }
    }
}
