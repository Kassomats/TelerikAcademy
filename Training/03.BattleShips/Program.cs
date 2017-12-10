using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.BattleShips
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dims = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[,] playerOneBoard = new int[dims[0], dims[1]];
            int[,] playerTwoBoard = new int[dims[0], dims[1]];

            for (int i = 0; i < dims[0]; i++)
            {
                int[] rowAdder = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < dims[1]; j++)
                {
                    playerOneBoard[i, j] = rowAdder[j];
                }
            }
            for (int i = 0; i < dims[0]; i++)
            {
                int[] rowAdder = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < dims[1]; j++)
                {
                    playerTwoBoard[i, j] = rowAdder[j];
                }
            }

            string[] playerRowCol = Console.ReadLine().Split().ToArray();
            List<string> moves = new List<string>();
            while (playerRowCol[0] != "END")
            {
                int row = int.Parse(playerRowCol[1]);
                int col = int.Parse(playerRowCol[2]);

                if (playerRowCol[0] == "P1") //p1 plays
                {
                    row = playerTwoBoard.GetLength(0) - 1 - row;

                    if (playerTwoBoard[row, col] == -1)
                    {
                        moves.Add("Try again!");
                    }
                    if (playerTwoBoard[row, col] == 0)
                    {
                        moves.Add("Missed");
                        playerTwoBoard[row, col] = -1;
                    }
                    if (playerTwoBoard[row, col] == 1)
                    {
                        moves.Add("Booom");
                        playerTwoBoard[row, col] = -1;
                    }
                }
                if (playerRowCol[0] == "P2") //p2 plays
                {
                    if (playerOneBoard[row, col] == -1)
                    {
                        moves.Add("Try again!");
                    }
                    if (playerOneBoard[row, col] == 0)
                    {
                        moves.Add("Missed");
                        playerOneBoard[row, col] = -1;
                    }
                    if (playerOneBoard[row, col] == 1)
                    {
                        moves.Add("Booom");
                        playerOneBoard[row, col] = -1;
                    }
                }
                playerRowCol = Console.ReadLine().Split().ToArray();
            }
            foreach (var item in moves)
            {
                Console.WriteLine(item);
            }
            int firstUnderstroyed = 0;
            int secondUndestroyed = 0;
            foreach (var item in playerOneBoard)
            {
                if (item == 1)
                {
                    firstUnderstroyed++;
                }
            }
            foreach (var item in playerTwoBoard)
            {
                if (item == 1)
                {
                    secondUndestroyed++;
                }
            }
            Console.WriteLine("{0}:{1}",firstUnderstroyed,secondUndestroyed);
        }
    }
}
