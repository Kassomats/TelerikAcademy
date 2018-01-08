using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<ListNode> listTester = new List<ListNode>();

            //ListNode firstNode = new ListNode(1);
            //ListNode secondNode = new ListNode(2);
            //ListNode thirdNode = new ListNode(3);
            //ListNode fourthNode = new ListNode(4);

            //firstNode.next = secondNode;
            //secondNode.next = thirdNode;
            //thirdNode.next = fourthNode;

            //List<int> helpMe = new List<int>();

            //LinkedList<int> linkList = new LinkedList<int>();
            //linkList.AddFirst(5);
            //linkList.AddLast(10);
            //linkList.AddAfter(linkList.First, 22);
            //linkList.AddBefore(linkList.Find(10), 13);
            ////Console.WriteLine(linkList.Find(13).Next.Value);
            ////Console.WriteLine(string.Join(" ",linkList));
            ////int asdasd = helpMe.Find(2);
            //Stack<int> stack = new Stack<int>();
            //stack.Push(3);
            //stack.Push(4);
            //stack.Push(5);
            //stack.(stack.Peek());
            //Console.WriteLine(string.Join(" ", stack));

            string input = "1+(2-(2+3)*4/(3+1))*5";

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    stack.Push(i);
                }
                else if (input[i] == ')')
                {
                    stack.Push(i);
                }
            }
            Console.WriteLine(string.Join(" ", stack.Reverse()));



        }
        //public void Deletion(List<ListNode> lister, ListNode noder)
        //{

        //}

        //public class ListNode
        //{
        //    public int val;
        //    public ListNode next;
        //    public ListNode(int x)
        //    {
        //        val = x;
        //    }
        //}
    }
}
