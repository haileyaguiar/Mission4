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

        public void PrintBoard(char[,] receivedBoard)
        {
            Console.WriteLine("Current Board:");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(receivedBoard[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }

        public char CheckForWinner(char[,] receivedBoard)
        {
            for (int i = 0; i < 3; i++)
            {
                // Check rows
                if (receivedBoard[i, 0] != ' ' && receivedBoard[i, 0] == receivedBoard[i, 1] && receivedBoard[i, 1] == receivedBoard[i, 2])
                    return receivedBoard[i, 0];
                Console.WriteLine(receivedBoard[i,0] + " wins!");

                // Check columns
                if (receivedBoard[0, i] != ' ' && receivedBoard[0, i] == receivedBoard[1, i] && receivedBoard[1, i] == receivedBoard[2, i])
                    return receivedBoard[0, i];
                    Console.WriteLine(receivedBoard[0, i] + " wins!");
            }

            // Check diagonals
            if (receivedBoard[0, 0] != ' ' && receivedBoard[0, 0] == receivedBoard[1, 1] && receivedBoard[1, 1] == receivedBoard[2, 2])
                return receivedBoard[0, 0];
                Console.WriteLine(receivedBoard[0, 0] + " wins!");

            if (receivedBoard[0, 2] != ' ' && receivedBoard[0, 2] == receivedBoard[1, 1] && receivedBoard[1, 1] == receivedBoard[2, 0])
                return receivedBoard[0, 2];
                Console.WriteLine(receivedBoard[0, 2] + " wins!");

            // If no winner, return C for Cat's game:
            return 'C';
        }
    }
}
