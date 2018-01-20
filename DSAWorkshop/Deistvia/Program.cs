using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deistvia
{
    public class Node
    {
        public int CountOfParents { get; set; }
        public int Value { get; set; }
        public List<Node> ChildsList { get; set; }

        public Node(int value)
        {
            this.Value = value;
            this.CountOfParents = 0;
            this.ChildsList = new List<Node>();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Node> nodeList = new List<Node>();
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int lastNumber = input[0];
            int numberOfCommands = input[1];

            for (int i = 0; i < lastNumber; i++)
            {
                nodeList.Add(new Node(i));
            }

            for (int i = 0; i < numberOfCommands; i++)
            {
                int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();

                int parent = orders[0];
                int child = orders[1];

                nodeList[parent].ChildsList.Add(nodeList[child]);
                nodeList[child].CountOfParents++;

            }

            bool allPrinted = false;
            bool[] alreadyPrinted = new bool[lastNumber];

            while (!allPrinted)
            {
                allPrinted = true;

                for (int i = 0; i < nodeList.Count; i++)
                {
                    if (nodeList[i].CountOfParents == 0 && !alreadyPrinted[i])
                    {
                        Console.WriteLine(nodeList[i].Value);
                        alreadyPrinted[i] = true;
                        if (nodeList[i].ChildsList.Count>0)
                        {
                            foreach (var child in nodeList[i].ChildsList)
                            {
                                child.CountOfParents--;
                            }
                        }
                        allPrinted = false;
                        break;
                    }
                }
            }
        }
    }
}
