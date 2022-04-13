using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFourGame 
{
    public class Board : BoardInterface
    { 

        //attributes
        // disc

        public static char disc = 'X'; //this sould be the object.

        //public static int selectedColumn = 0;
        public int selectedColumn;

        // 6 by 7 character array representing the game board
        public char[,] boardGrid = new char[Rows, Columns];

        // This is a class for our board.
        // number of rows in the board
        public static int Rows { get; private set; } = 6;

        // number of columns in the board
        public static int Columns { get; private set; } = 7;

        Message output = new MessageEnglish();

        public Board()
        {
            //default constructor
        }



        // fill game board array with empty characters
        public void Initiate()
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

        public void SetColor(char c) // The object should be send in the initiate game, we dont receive the Message object here for the Color setting.  Lets leave it like that.
        {

            if (c == 'X')
            { 
                output.ForegroundRed();  //calling the output object of the Player
                
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
        public void Display()
        {
           
            output.ForegroundMagenta();  //
            output.WriteLine("  1   2   3   4   5   6   7  ");
            output.ForegroundBlue();
            output.WriteLine("|---|---|---|---|---|---|---|");

            int i, j;

            for (i = 0; i < Rows; i++)
            {
                for (j = 0; j < Columns; j++)
                {
                    output.ForegroundBlue();
                    output.Write("| ");
                    SetColor(boardGrid[i, j]);
                    output.Write($"{boardGrid[i, j]} ");
                    output.ForegroundBlue();
                }

                output.WriteLine("|");
                output.WriteLine("|---|---|---|---|---|---|---|");

            }
        }
    }
}
