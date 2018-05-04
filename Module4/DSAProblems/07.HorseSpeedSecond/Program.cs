using System;
using System.Collections.Generic;

namespace _07.HorseSpeedSecond
{
    public class Position
    {
        public Position(int row, int col)
        {
            Row = row;
            Col = col;
        }
        public int Row { get; }
        public int Col { get; }
    }
    class Program
    {
        static int[,] matrix;
        static Queue<Position> moves = new Queue<Position>();
        static int currentNumber = 1;
        static int Rowz;
        static int Colz;

        static void Main(string[] args)
        {
            //read
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Rowz = n;
            Colz = m;
            //setup
            matrix = new int[n, m];
            moves = new Queue<Position>();
            var firstPosition = new Position(r, c);
            matrix[r, c] = currentNumber;
            //action
            moves.Enqueue(firstPosition);
            while (moves.Count > 0)
            {
                var mayBeFirstNewPosition = moves.Dequeue();
                var row = mayBeFirstNewPosition.Row;
                var col = mayBeFirstNewPosition.Col;

                if (currentNumber == matrix[mayBeFirstNewPosition.Row, mayBeFirstNewPosition.Col])
                {
                    currentNumber++;
                }
                CheckIfPossibleAdd(row - 1, col - 2);
                CheckIfPossibleAdd(row - 2, col - 1);
                CheckIfPossibleAdd(row - 2, col + 1);
                CheckIfPossibleAdd(row - 1, col + 2);
                CheckIfPossibleAdd(row + 1, col + 2);
                CheckIfPossibleAdd(row + 2, col + 1);
                CheckIfPossibleAdd(row + 2, col - 1);
                CheckIfPossibleAdd(row + 1, col - 2);
            }
            PrintMatrix(matrix);
        }

        static void CheckIfPossibleAdd(int row, int col)
        {
            if (row > Rowz - 1 || row < 0 ||
                col > Colz - 1 || col < 0 ||
                matrix[row, col] != 0)
            {
                return;
            }
            matrix[row, col] = currentNumber;
            moves.Enqueue(new Position(row, col));
        }
        static void PrintMatrix(int[,] matrix)
        {
            var col = matrix.GetLength(1) / 2;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.WriteLine(matrix[i, col]);
            }
        }
    }
}
