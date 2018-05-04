using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.HorseSpread
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
        static int currentNumber = 1;
        static int[,] matrix;
        static int lastPostitionValue;
        static void Main(string[] args)
        {
            //read
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            //setup
            matrix = new int[n, m];
            var moves = new Queue<Position>();
            var firstPosition = new Position(r, c);
            matrix[r, c] = currentNumber;
            lastPostitionValue = currentNumber;
            currentNumber++;
           
            //action
            moves.Enqueue(firstPosition);
            while (moves.Count > 0)
            {
                var mayBeFirstNewPosition = moves.Dequeue();
                if (lastPostitionValue != matrix[mayBeFirstNewPosition.Row,mayBeFirstNewPosition.Col])
                {
                    currentNumber++;
                    lastPostitionValue++;
                }
                GoNextPosAndMarkIt(mayBeFirstNewPosition, moves);
            }
            PrintMatrix(matrix);
        }
        static void GoNextPosAndMarkIt(Position current, Queue<Position> moves)
        {
            var listOfPosition = new List<Position>
            {
                new Position(current.Row - 1, current.Col - 2),
                new Position(current.Row - 2, current.Col - 1),
                new Position(current.Row - 2, current.Col + 1),
                new Position(current.Row - 1, current.Col + 2),
                new Position(current.Row + 1, current.Col + 2),
                new Position(current.Row + 2, current.Col + 1),
                new Position(current.Row + 2, current.Col - 1),
                new Position(current.Row + 1, current.Col - 2),
            };
            foreach (var pos in listOfPosition)
            {
                CheckIfPossibleAdd(pos,moves);
            }
        }
        static void CheckIfPossibleAdd(Position toAdd, Queue<Position> moves)
        {
            var checkingRow = toAdd.Row;
            var checkingCol = toAdd.Col;
            if (checkingRow > matrix.GetLength(0) - 1 || checkingRow < 0 ||
                checkingCol > matrix.GetLength(1) - 1 || checkingCol < 0 ||
                matrix[checkingRow, checkingCol] != 0)
            {
                return;
            }
            matrix[checkingRow, checkingCol] = currentNumber;
            moves.Enqueue(toAdd);
        }
        static void PrintMatrix(int[,] matrix)
        {
            var col = matrix.GetLength(1) / 2;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.WriteLine(matrix[i,col]);
            }
        }
    }
}
