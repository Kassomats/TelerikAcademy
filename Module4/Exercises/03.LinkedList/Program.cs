using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var myList = new MyLinkedList<string>();
            myList.Add("5");
            myList.Add("10");
            myList.AddAfter("5", "100");
            myList.AddAfter("100", "5");
            myList.AddAfter("10", "last");
            myList.Add("really last");

            myList.Print();
        }
    }
    public class LLNode<T> 
    {
        private LLNode<T> prev;
        private LLNode<T> next;
        private T value;
        public LLNode(T value)
        {
            this.value = value;
        }

        public T Value { get => value; set => this.value = value; }
        public LLNode<T> Next { get => next; set => next = value; }
        public LLNode<T> Prev { get => prev; set => prev = value; }
    }
    public class MyLinkedList<T>
    {
        private LLNode<T> first;
        private LLNode<T> last;

        public LLNode<T> First { get => first; set => first = value; }
        public LLNode<T> Last { get => last; set => last = value; }

        public void Add(T value)
        {
            var toAdd = new LLNode<T>(value);
            if (first == null)
            {
                this.First = toAdd;
                this.Last = toAdd;
            }
            else
            {
                this.last.Next = toAdd;
                toAdd.Prev = last;
                this.last = toAdd;
            }
        }
        public void AddAfter(T valueToAddAfter, T newNodeValue)
        {
            LLNode<T> nodeToAddAfter = null;
            LLNode<T> searchingNode = first;

            while (searchingNode != null && !searchingNode.Value.Equals(valueToAddAfter))
            {
                if (searchingNode.Value.Equals(valueToAddAfter))
                {
                    nodeToAddAfter = searchingNode;
                }
                searchingNode = searchingNode.Next;
            }
            if (searchingNode != null)
            {
                nodeToAddAfter = searchingNode;
            }
            if (nodeToAddAfter == null)
            {
                Console.WriteLine("Such node doesn't exist");
            }
            else
            {
                var nodeToAddAftersNext = nodeToAddAfter.Next;
                var toAdd = new LLNode<T>(newNodeValue);

                if (nodeToAddAftersNext != null)
                {

                    nodeToAddAftersNext.Prev = toAdd;
                    nodeToAddAfter.Next = toAdd;

                    toAdd.Prev = nodeToAddAfter;
                    toAdd.Next = nodeToAddAftersNext;
                }
                else
                {
                    nodeToAddAfter.Next = toAdd;
                    toAdd.Prev = nodeToAddAfter;
                    this.Last = toAdd;
                }
            }
        }
        public void Print()
        {
            var nodeToPrint = first;

            while (nodeToPrint != null)
            {
                Console.WriteLine(nodeToPrint.Value);
                nodeToPrint = nodeToPrint.Next;
            }
        }
    }
}
