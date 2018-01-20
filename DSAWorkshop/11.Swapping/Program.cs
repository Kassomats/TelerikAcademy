using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Swapping
{
    public class Node
    {
        public Node Previous;
        public Node Next;

        public int Value { get; set; }
       

        public Node(int value)
        {
            this.Value = value;
            this.Previous = null;
            this.Next = null;
        }
        public Node MostLeft()
        {
            Node current = this;
            if (current.Previous == null)
            {
                return current;
            }
            while (true)
            {
                current = current.Previous;
                if (current.Previous == null)
                {
                    return current;
                }
            }
            
        }
        public Node MostRight()
        {
            Node current = this;
            if (current.Next == null)
            {
                return current;
            }
            while (true)
            {
                current = current.Next;
                if (current.Next == null)
                {
                    return current;
                }
            }
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            int[] whereToSwap = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Node[] arr = new Node[numbers];
            for (int i = 0; i < numbers; i++)
            {
                arr[i] = new Node(i);
            }

            for (int i = 1; i < numbers-1; i++)
            {
                Node current = arr[i];
                current.Previous = arr[i-1];
                current.Previous.Next = current;
                current.Next = arr[i+1];
            }

            for (int i = 0; i < whereToSwap.Length; i++)
            {
                int swapHere = whereToSwap[i];

                foreach (var item in arr)
                {
                    if (item.Value == swapHere)
                    {
                        item.Previous.Next = null;
                        item.Next.Previous = null;
                        
                        item.Previous = item.MostRight();
                        item.Next = item.MostLeft();
                                           
                       

                        item.Previous.Next = item;
                        item.Next.Previous = item;
                    }
                }
            }

            Node check = arr[0].MostLeft();

            while (true)
            {
                Console.WriteLine(check.Value);
                check = check.Next;

                if (check.Next == null)
                {
                    break;
                }
            }


        }
    }
}
