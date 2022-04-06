﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFourGame
{
    public class Board
    {
        // This is a class for our board.
        // number of rows in the board
        public static int Rows { get; private set; } = 6;

        // number of columns in the board
        public static int Columns { get; private set; } = 7;

        // 6 by 7 character array representing the game board

        public char[,] boardGrid = new char[Rows, Columns];

        // disc
        public static char disc = 'X';

        //public static int selectedColumn = 0;
        public int selectedColumn;

        // fill game board array with empty characters
        public void Initiate()
        {
            // r represents rows while c represents columns in the array

            for (int r = 0; r < Rows; r++)
            {
                for (int c = 0; c < Columns; c++)
                {
                    boardGrid[r, c] = ' ';
                }
            }
        }


        // print the board at its current state
        public void Display()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("  1   2   3   4   5   6   7  ");

            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("|---|---|---|---|---|---|---|");

            int i, j;

            for (i = 0; i < Rows; i++)
            {
                for (j = 0; j < Columns; j++)
                {
                    Console.Write($"| {boardGrid[i, j]} ");
                }
                Console.WriteLine("|");
                Console.WriteLine("|---|---|---|---|---|---|---|");
            }
        }
    }
}
