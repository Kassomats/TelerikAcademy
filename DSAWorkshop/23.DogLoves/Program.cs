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
        public bool Printed { get; set; }
        public HashSet<Node> ChildsList { get; set; }

        public Node()
        {
            this.Printed = false;
            this.CountOfParents = 0;
            this.ChildsList = new HashSet<Node>();
        }

        //public int CompareTo(Node second)
        //{
        //    if (this.Name.CompareTo(second.Name) > 0)
        //    {
        //        return 1;
        //    }
        //    else if (this.Name.CompareTo(second.Name) < 0)
        //    {
        //        return -1;
        //    }
        //    else if (this.Name.CompareTo(second.Name) == 0)
        //    {
        //        if (this.Age > second.Age)
        //        {
        //            return -1;
        //        }
        //        else if (this.Age < second.Age)
        //        {
        //            return 1;
        //        }
        //        else if (this.Age == second.Age)
        //        {
        //            return 0;
        //        }
        //    }

        //    return 0;
        //}

    }
    class Program
    {
        static void Main(string[] args)
        {
           

            int inpLine = int.Parse(Console.ReadLine());
            SortedDictionary<int, Node> myList = new SortedDictionary<int, Node>();

           

            for (int i = 0; i < inpLine; i++)
            {
                string [] orders = Console.ReadLine().Split().ToArray();
                if (!myList.ContainsKey(int.Parse(orders[0])))
                {
                    myList.Add(int.Parse(orders[0]), new Node());
                }
                if (!myList.ContainsKey(int.Parse(orders[3])))
                {
                    myList.Add(int.Parse(orders[3]), new Node());
                }
                if (orders[2] == "before")
                {
                    int parent = int.Parse(orders[0]);
                    int child = int.Parse(orders[3]);

                    if (!myList[parent].ChildsList.Contains(myList[child]))
                    {
                        myList[parent].ChildsList.Add(myList[child]);

                        myList[child].CountOfParents++;
                    }
                   
                }
                else if (orders[2] == "after")
                {
                    

                    int parent = int.Parse(orders[3]);
                    int child = int.Parse(orders[0]);

                    if (!myList[parent].ChildsList.Contains(myList[child]))
                    {
                        myList[parent].ChildsList.Add(myList[child]);
                        myList[child].CountOfParents++;
                    }
                }
            }

            bool allPrinted = false;


            StringBuilder sb = new StringBuilder();

            while (!allPrinted)
            {
                allPrinted = true;

                foreach (var item in myList)
                {
                    if (item.Value.CountOfParents == 0)
                    {

                        if (!item.Value.Printed)
                        {
                            if (item.Key == 0 && sb.Length == 0)
                            {
                                continue;
                            }
                            sb.Append(item.Key);
                            item.Value.Printed = true;
                            allPrinted = false;

                            if (item.Value.ChildsList.Count > 0)
                            {
                                foreach (var child in item.Value.ChildsList)
                                {
                                    child.CountOfParents--;
                                }
                            }
                            break;
                        }
                        
                    }
                }
            }

            Console.WriteLine(sb);
        }
    }
}
