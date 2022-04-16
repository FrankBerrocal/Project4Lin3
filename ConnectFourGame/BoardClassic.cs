using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFourGame
{
    public class BoardClassic : Board
    {
        Message output = new MessageEnglish();

        public BoardClassic()
        {
            //default constructor
        }


        // fill game board array with empty characters
        public override void Initiate()
        {
            // r represents rows while c represents columns in the array

            for (int r = 0; r < Rows; r++)
            {
                for (int c = 0; c < Columns; c++)
                {
                    boardGrid[r, c] = ' ';  //spaces used to fill the board.
                }
            }
        }

        public override void SetColor(char c) // Modified by Peter!
        {

            if (c == 'X')
            {
                output.ForegroundRed();
            }
            else if (c == 'O')
            {
                output.ForegroundYellow();
            }
            else
            {
                output.ForegroundBlue();
            }
        }

        // print the board at its current state
        public override void Display()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;  //font color

            Console.WriteLine("  1   2   3   4   5   6   7  ");

            Console.ForegroundColor = ConsoleColor.Blue;  //font color

            Console.WriteLine("|---|---|---|---|---|---|---|");

            int i, j;

            for (i = 0; i < Rows; i++)
            {
                for (j = 0; j < Columns; j++)
                {
                    Console.ForegroundColor = ConsoleColor.Blue; // Modified by Peter!
                    Console.Write("| "); // Modified by Peter!
                    SetColor(boardGrid[i, j]); // Modified by Peter!
                    Console.Write($"{boardGrid[i, j]} "); // Modified by Peter!
                    Console.ForegroundColor = ConsoleColor.Blue; // Modified by Peter!
                    //Console.Write($"| {boardGrid[i, j]} ");
                }
                Console.WriteLine("|");
                Console.WriteLine("|---|---|---|---|---|---|---|"); //display row number not efficient.
            }
        }
    }
}
