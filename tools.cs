using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Mission4
{
    internal class tools
    {
        private char[,] board;

        public void SetBoard(char[,] receivedBoard)
        {
            board = receivedBoard;
        }

        public void PrintBoard()
        {
            Console.WriteLine("Current Board:");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(board[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }

        public char CheckForWinner()
        {
            for (int i = 0; i < 3; i++)
            {
                // Check rows
                if (board[i, 0] != ' ' && board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                    return board[i, 0];

                // Check columns
                if (board[0, i] != ' ' && board[0, i] == board[1, i] && board[1, i] == board[2, i])
                    return board[0, i];
            }

            // Check diagonals
            if (board[0, 0] != ' ' && board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
                return board[0, 0];

            if (board[0, 2] != ' ' && board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
                return board[0, 2];

            // If no winner, return C for Cat's game:
            return 'C';
        }
    }
}
