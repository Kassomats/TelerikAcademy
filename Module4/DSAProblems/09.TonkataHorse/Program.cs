using System;
using System.Collections.Generic;
namespace Horse3
{
    public class Coord
    {
        public Coord(int row, int col)
        {
            this.Row = row;
            this.Col = col;
        }
        public int Row { get; set; }
        public int Col { get; set; }
    }
    class Horse3
    {
        public static Queue<Coord> queue = new Queue<Coord>();
        public static int[,] matrix;
        public static int ToniValue = 1;
        public static int ToniMaxRowz = 0;
        public static int ToniMaxColz = 0;
        public static int col = 0;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            ToniMaxRowz = n;
            ToniMaxColz = m;
            matrix = new int[n, m];
            ToniValue = 1;
            matrix[r, c] = 1;
            queue.Enqueue(new Coord(r, c));
            while (queue.Count > 0)
            {
                Coord currentCoord = queue.Dequeue();
                int currentRow = currentCoord.Row;
                int currentCol = currentCoord.Col;
                if (ToniValue == matrix[currentRow, currentCol])
                {
                    ToniValue++;
                }
                MartoMethod(currentRow - 1, currentCol - 2);
                MartoMethod(currentRow - 2, currentCol - 1);
                MartoMethod(currentRow - 2, currentCol + 1);
                MartoMethod(currentRow - 1, currentCol + 2);
                MartoMethod(currentRow + 1, currentCol + 2);
                MartoMethod(currentRow + 2, currentCol + 1);
                MartoMethod(currentRow + 2, currentCol - 1);
                MartoMethod(currentRow + 1, currentCol - 2);
            }
            PrintXcolumn(matrix);
        }
        static void MartoMethod(int row, int col)
        {
            if (row > ToniMaxRowz - 1 || row < 0 ||
                col > ToniMaxColz - 1 || col < 0 ||
                matrix[row, col] != 0)
            {
                return;
            }
            matrix[row, col] = ToniValue;
            queue.Enqueue(new Coord(row, col));
        }
        private static void PrintXcolumn(int[,] matrix)
        {
            int xColumn = matrix.GetLength(1) / 2;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.WriteLine(matrix[i, xColumn]);
            }
        }
    }
}

