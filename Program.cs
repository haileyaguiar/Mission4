﻿// See https://aka.ms/new-console-template for more information
using Mission4;
using System.Runtime.InteropServices;
Console.WriteLine("Hello, World!");


//The “Driver” class (the Program.cs class with the main method where the program begins)
//will:
//• Welcome the user to the game
//• Create a game board array to store the players’ choices
//• Ask each player in turn for their choice and update the game board array
//• Print the board by calling the method in the supporting class
//• Check for a winner by calling the method in the supporting class, and notify the players
//when a win has occurred and which player won the game



//The supporting class (with whichever name you choose) will:
//• Receive the “board” array from the driver class
//• Contain a method that prints the board based on the information passed to it
//• Contain a method that receives the game board array as input and returns if there is a
//winner and who it was


Console.WriteLine("What is the first players name?");
string userName1 = Console.ReadLine();
Console.WriteLine("What is the second players name?");
string userName2 = Console.ReadLine();
//• Welcome the users to the game
Console.WriteLine($"Hello {userName1} and {userName2}!");


//• Create a game board array to store the players’ choices
// list of length 9 because the board is 3x3
char[,] gameboard = { {'-', '-', '-' }, { '-', '-', '-'}, { '-', '-', '-' } };

tools tls = new tools();


tls.PrintBoard(gameboard);

Boolean first = true;
while (1 != 0)
{
    // First Player goes, they're 'X'
    if (first == true)
    {
        Boolean ask = false; // Sees if their input is even valid
        int rowIndex = 0; //Row index wanting to be changed
        int colIndex = 0; //Column index wanting to be changed

        while (ask == false) //"While a proper position hasn't been received"
        {
            //Takes in inputs
            Console.WriteLine(userName1 + ", what row do you want to add to?");
            rowIndex = int.Parse(Console.ReadLine());
            Console.WriteLine(userName1 + ", what column do you want to add to?");
            colIndex = int.Parse(Console.ReadLine());

            //Checks the values in given row
            if (gameboard[rowIndex - 1, colIndex - 1] == 'X')
            {
                Console.WriteLine("You've already placed an \'X\' there, silly!");
            }
            else 
            {
                if (gameboard[rowIndex - 1, colIndex - 1] == 'O')
                {
                    Console.WriteLine(userName2 + " already placed an \'O\' there, silly!");
                }
                //The value was accepted
                else
                {
                    ask = true;
                }
            }

        }
        //Changes the value on the board
        gameboard[rowIndex - 1, colIndex - 1] = 'X';
        //Its the second player's turn
        first = false;

    }

    //Second Player goes, they're 'O'
    else
    {
        
        Boolean ask = false;
        int rowIndex = 0;
        int colIndex = 0;

        while (ask == false) //If an open spot has been selected, then you can continue
        {
            //Received column and row indexes
            Console.WriteLine(userName2 + ", what row do you want to add to?");
            rowIndex = int.Parse(Console.ReadLine());
            Console.WriteLine(userName2 + ", what column do you want to add to?");
            colIndex = int.Parse(Console.ReadLine());

            //Check the spot if it's available
            if (gameboard[rowIndex - 1, colIndex - 1] == 'X')
            {
                Console.WriteLine(userName1 + " already placed an \'X\' there, silly!");
            }
            else 
            {
                if (gameboard[rowIndex - 1, colIndex - 1] == 'O')
                {
                    Console.WriteLine("You've already placed an \'O\' there, silly!");
                }
                else
                {
                    ask = true;
                }
            }


        }
        gameboard[rowIndex - 1, colIndex - 1] = 'O';
        //Back to the first player
        first = true;
    }

    tls.PrintBoard(gameboard);
    if (tls.CheckForWinner(gameboard) == 'X')
    {
        Console.WriteLine(userName1 + " has won!");
        break;
    }
    if (tls.CheckForWinner(gameboard) == 'O')
    {
        Console.WriteLine(userName2 + " has won!");
        break;
    }
    if (tls.CheckForWinner(gameboard) == 'C')
    {
        Console.WriteLine("It's a tie!");
        break;
    }
    else
    {
        continue;
    }
}




Console.WriteLine("The Game has ended!");

//• Ask each player in turn for their choice and update the game board array

//public void SetBoard(char[,] receivedBoard)
//public void PrintBoard()
//public char CheckForWinner()












