using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitty
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] path = Console.ReadLine().ToCharArray();
            int[] movePattern = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int moves = 1;
            int souls = 0;
            int food = 0;
            int deadlocks = 0;

            int currentPosition = 0;
            switch (path[0])
            {
                case '@':
                    souls++;
                    break;
                case '*':
                    food++;
                    break;
                case 'x':
                    deadlocks++;
                    Console.WriteLine("You are deadlocked, you greedy kitty!");
                    Console.WriteLine("Jumps before deadlock: 0");
                    return;
                case 'S':
                    break;
            }
            path[currentPosition] = 'S';

            for (int i = 0; i < movePattern.Length; i++)
            {
                currentPosition += movePattern[i];
                currentPosition = currentPosition % path.Length;
                if (currentPosition < 0)
                {
                    currentPosition += path.Length;
                }
                else if (currentPosition >= path.Length)
                {
                    currentPosition -= path.Length;
                }

                switch (path[currentPosition])
                {
                    case '@':
                        souls++;
                        path[currentPosition] = 'S';
                        break;
                    case '*':
                        food++;
                        path[currentPosition] = 'S';
                        break;
                    case 'x':
                        if (currentPosition % 2 == 0 && souls - 1 >= 0)
                        {
                            souls--;
                            path[currentPosition] = '@';
                        }
                        else if (currentPosition % 2 == 1 && food - 1 >= 0)
                        {
                            food--;
                            path[currentPosition] = '*';
                        }
                        else
                        {
                            Console.WriteLine("You are deadlocked, you greedy kitty!");
                            Console.WriteLine("Jumps before deadlock: {0}", moves);
                            return;
                        }
                        deadlocks++;
                       
                        break;
                    case 'S':
                        break;
                }
                moves++;
            }         
            Console.WriteLine("Coder souls collected: {0}" , souls);
            Console.WriteLine("Food collected: {0}" , food);
            Console.WriteLine("Deadlocks: {0}" , deadlocks);
        }
    }
}
