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
            Console.WriteLine("\nCurrent Board:");

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
            int tieCounter = 0;
            for (int i = 0; i < 3; i++)
            {
                // Check rows
                if ((receivedBoard[i, 0] == receivedBoard[i, 1]) && (receivedBoard[i, 0] == receivedBoard[i, 2]))
                    {
                        if (receivedBoard[i,0] == 'X')
                        {
                            return 'X';
                        }
                        if (receivedBoard[i,0] == 'O')
                        {
                            return 'O';
                        }
                    }
                    //return receivedBoard[i, 0];
                    
                

                // Check columns
                if ((receivedBoard[0, i] == receivedBoard[1, i]) && (receivedBoard[0, i] == receivedBoard[2, i]))
                {
                        if (receivedBoard[0, i] == 'X')
                        {
                            return 'X';
                        }
                        if (receivedBoard[0, i] == 'O')
                        {
                            return 'O';
                        }
                }
                
            }

            // Check diagonals
            if ((receivedBoard[0, 0] == receivedBoard[1, 1]) && (receivedBoard[1, 1] == receivedBoard[2, 2]))
            {
                if (receivedBoard[0, 0] == 'X')
                {
                    return 'X';
                }
                if (receivedBoard[0, 0] == 'O')
                {
                    return 'O';
                }
            }
                
               

            if ((receivedBoard[0, 2] == receivedBoard[1, 1]) && (receivedBoard[1, 1] == receivedBoard[2, 0]))
            {
                if (receivedBoard[0, 2] == 'X')
                {
                    return 'X';
                }
                if (receivedBoard[0, 2] == 'O')
                {
                    return 'O';
                }
            }

            // If no winner, return C for Cat's game:
            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    if ((receivedBoard[i, j]) != '-')
                    {
                        tieCounter++;
                        if (tieCounter == 9)
                        {
                            return 'C';
                        }
                    }
                    if ((receivedBoard[i, j]) == (receivedBoard[2, 2]))
                    {
                        tieCounter = 0;
                    }
                    else
                    {
                        tieCounter = 0;
                    }
                }
            }
            return 'N';
        }

    }
}
