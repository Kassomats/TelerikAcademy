using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.LargestAreaInMatrix
{
    struct Coord
    {
        public Coord(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int X { get; set; }

        public int Y { get; set; }
    }

    class LargestAreaInMatrix
    {
        static int[] sizes;
        static int[,] matrix;
        static bool[,] beenThere;

        static void Main(string[] args)
        {
            sizes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            matrix = new int[sizes[0], sizes[1]];
            for (int r = 0; r < sizes[0]; r++)
            {
                int[] row = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                for (int c = 0; c < sizes[1]; c++)
                {
                    matrix[r, c] = row[c];
                }
            }
            beenThere = new bool[sizes[0], sizes[1]];

            int largestArea = 1;

            int area = new int();
            for (int row = 0; row < sizes[0]; row++)
            {
                for (int col = 0; col < sizes[1]; col++)
                {
                    int searched = matrix[row, col];
                    area = FindLargestAreaBFS(searched, row, col);

                    if (area > largestArea)
                    {
                        largestArea = area;
                    }
                }
            }

            Console.WriteLine(largestArea);
        }

        private static int FindLargestAreaDFSIterative(int searched, int row, int col)
        {
            int largestArea = 0;

            Stack<Coord> stack = new Stack<Coord>();
            stack.Push(new Coord(row, col));

            beenThere[row, col] = true;


            while (stack.Count != 0)
            {
                Coord coord = stack.Pop();
                row = coord.X;
                col = coord.Y;

                largestArea++;

                if (IsValid(row + 1, col) && matrix[row + 1, col] == searched)
                {
                    stack.Push(new Coord() { X = row + 1, Y = col });
                    beenThere[row + 1, col] = true;
                }
                if (IsValid(row, col + 1) && matrix[row, col + 1] == searched)
                {
                    stack.Push(new Coord() { X = row, Y = col + 1 });
                    beenThere[row, col + 1] = true;
                }
                if (IsValid(row - 1, col) && matrix[row - 1, col] == searched)
                {
                    stack.Push(new Coord() { X = row - 1, Y = col });
                    beenThere[row - 1, col] = true;
                }
                if (IsValid(row, col - 1) && matrix[row, col - 1] == searched)
                {
                    stack.Push(new Coord() { X = row, Y = col - 1 });
                    beenThere[row, col - 1] = true;
                }
            }

            return largestArea;
        }

        private static int FindLargestAreaBFS(int searched, int row, int col)
        {
            int largestArea = 0;

            Queue<Coord> queue = new Queue<Coord>();
            queue.Enqueue(new Coord(row, col));

            beenThere[row, col] = true;


            while (queue.Count != 0)
            {
                Coord coord = queue.Dequeue();
                row = coord.X;
                col = coord.Y;

                largestArea++;

                if (IsValid(row + 1, col) && matrix[row + 1, col] == searched)
                {
                    queue.Enqueue(new Coord() { X = row + 1, Y = col });
                    beenThere[row + 1, col] = true;
                }
                if (IsValid(row, col + 1) && matrix[row, col + 1] == searched)
                {
                    queue.Enqueue(new Coord() { X = row, Y = col + 1 });
                    beenThere[row, col + 1] = true;
                }
                if (IsValid(row - 1, col) && matrix[row - 1, col] == searched)
                {
                    queue.Enqueue(new Coord() { X = row - 1, Y = col });
                    beenThere[row - 1, col] = true;
                }
                if (IsValid(row, col - 1) && matrix[row, col - 1] == searched)
                {
                    queue.Enqueue(new Coord() { X = row, Y = col - 1 });
                    beenThere[row, col - 1] = true;
                }
            }

            return largestArea;
        }

        private static bool IsValid(int row, int col)
        {
            return row > -1 && row < sizes[0] && col > -1 && col < sizes[1] && !beenThere[row, col];
        }

        private static int FindLargestAreaDFSRecuresively(int searched, int row, int col)
        {
            int equalElements = 0;

            bool isInMatrix = !(row < 0 || row >= sizes[0] || col < 0 || col >= sizes[1]);

            if (isInMatrix && searched == matrix[row, col] && !beenThere[row, col])
            {
                equalElements++;
                beenThere[row, col] = true;

                equalElements += FindLargestAreaDFSRecuresively(searched, row, col + 1);
                equalElements += FindLargestAreaDFSRecuresively(searched, row + 1, col);
                equalElements += FindLargestAreaDFSRecuresively(searched, row, col - 1);
                equalElements += FindLargestAreaDFSRecuresively(searched, row - 1, col);
            }

            return equalElements;
        }
    }
}
