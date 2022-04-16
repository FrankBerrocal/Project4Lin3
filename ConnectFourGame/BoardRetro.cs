using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFourGame
{
    public class BoardRetro : Board
    {
        Message output = new MessageEnglish();

        public BoardRetro()
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

        public char DrawDisc(char c)
        {
            char disc;

            if (c == 'X')
            {
                output.ForegroundRed();
                disc = '*';
            }
            else if (c == 'O')
            {
                output.ForegroundYellow();
                disc = '*';
            }
            else
            {
                output.ForegroundBlue();
                disc = ' ';
            }

            return disc;
        }

        // print the board at its current state
        public override void Display()
        {
            //ConsoleColor red = ConsoleColor.Red;
            //ConsoleColor yellow = ConsoleColor.Yellow;
            ConsoleColor blue = ConsoleColor.Blue;

            char d;

            // print the board and the scores according to current game:

            // Windows only implementation
            if (OperatingSystem.IsWindows())
            {
                Console.SetWindowSize(120, 45);
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("    1       2       3       4       5       6       7    ");
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("|-------|-------|-------|-------|-------|-------|-------||");
            //Console.WriteLine("|       |       |       |       |       |       |       ||");


            // top line - row 0
            Console.Write("|  ");
            d = DrawDisc(boardGrid[0, 0]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write("  |  ");

            d = DrawDisc(boardGrid[0, 1]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write("  |  ");

            d = DrawDisc(boardGrid[0, 2]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write("  |  ");

            d = DrawDisc(boardGrid[0, 3]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write("  |  ");

            d = DrawDisc(boardGrid[0, 4]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write("  |  ");

            d = DrawDisc(boardGrid[0, 5]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write("  |  ");

            d = DrawDisc(boardGrid[0, 6]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.WriteLine("  ||");


            // middle line - row 0
            Console.Write("| ");
            d = DrawDisc(boardGrid[0, 0]);
            Console.Write($"{d}{d}{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write(" | ");

            d = DrawDisc(boardGrid[0, 1]);
            Console.Write($"{d}{d}{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write(" | ");

            d = DrawDisc(boardGrid[0, 2]);
            Console.Write($"{d}{d}{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write(" | ");

            d = DrawDisc(boardGrid[0, 3]);
            Console.Write($"{d}{d}{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write(" | ");

            d = DrawDisc(boardGrid[0, 4]);
            Console.Write($"{d}{d}{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write(" | ");

            d = DrawDisc(boardGrid[0, 5]);
            Console.Write($"{d}{d}{d}{d}{d}"); ;
            Console.ForegroundColor = blue;
            Console.Write(" | ");

            d = DrawDisc(boardGrid[0, 6]);
            Console.Write($"{d}{d}{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.WriteLine(" ||");


            // bottom line - row 0
            Console.Write("|  ");
            d = DrawDisc(boardGrid[0, 0]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write("  |  ");

            d = DrawDisc(boardGrid[0, 1]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write("  |  ");

            d = DrawDisc(boardGrid[0, 2]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write("  |  ");

            d = DrawDisc(boardGrid[0, 3]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write("  |  ");

            d = DrawDisc(boardGrid[0, 4]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write("  |  ");

            d = DrawDisc(boardGrid[0, 5]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write("  |  ");

            d = DrawDisc(boardGrid[0, 6]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.WriteLine("  ||");

            //Console.WriteLine("|       |       |       |       |       |       |       ||");
            Console.WriteLine("|-------|-------|-------|-------|-------|-------|-------||");
            // Console.WriteLine("|       |       |       |       |       |       |       ||");


            // top line - row 1
            Console.Write("|  ");
            d = DrawDisc(boardGrid[1, 0]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write("  |  ");

            d = DrawDisc(boardGrid[1, 1]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write("  |  ");

            d = DrawDisc(boardGrid[1, 2]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write("  |  ");

            d = DrawDisc(boardGrid[1, 3]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write("  |  ");

            d = DrawDisc(boardGrid[1, 4]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write("  |  ");

            d = DrawDisc(boardGrid[1, 5]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write("  |  ");

            d = DrawDisc(boardGrid[1, 6]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.WriteLine("  ||");


            // middle line - row 1
            Console.Write("| ");
            d = DrawDisc(boardGrid[1, 0]);
            Console.Write($"{d}{d}{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write(" | ");

            d = DrawDisc(boardGrid[1, 1]);
            Console.Write($"{d}{d}{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write(" | ");

            d = DrawDisc(boardGrid[1, 2]);
            Console.Write($"{d}{d}{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write(" | ");

            d = DrawDisc(boardGrid[1, 3]);
            Console.Write($"{d}{d}{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write(" | ");

            d = DrawDisc(boardGrid[1, 4]);
            Console.Write($"{d}{d}{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write(" | ");

            d = DrawDisc(boardGrid[1, 5]);
            Console.Write($"{d}{d}{d}{d}{d}"); ;
            Console.ForegroundColor = blue;
            Console.Write(" | ");

            d = DrawDisc(boardGrid[1, 6]);
            Console.Write($"{d}{d}{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.WriteLine(" ||");


            // bottom line - row 1
            Console.Write("|  ");
            d = DrawDisc(boardGrid[1, 0]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write("  |  ");

            d = DrawDisc(boardGrid[1, 1]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write("  |  ");

            d = DrawDisc(boardGrid[1, 2]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write("  |  ");

            d = DrawDisc(boardGrid[1, 3]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write("  |  ");

            d = DrawDisc(boardGrid[1, 4]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write("  |  ");

            d = DrawDisc(boardGrid[1, 5]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write("  |  ");

            d = DrawDisc(boardGrid[1, 6]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.WriteLine("  ||");

            // Console.WriteLine("|       |       |       |       |       |       |       ||");
            Console.WriteLine("|-------|-------|-------|-------|-------|-------|-------||");
            //Console.WriteLine("|       |       |       |       |       |       |       ||");


            // top line - row 2
            Console.Write("|  ");
            d = DrawDisc(boardGrid[2, 0]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write("  |  ");

            d = DrawDisc(boardGrid[2, 1]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write("  |  ");

            d = DrawDisc(boardGrid[2, 2]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write("  |  ");

            d = DrawDisc(boardGrid[2, 3]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write("  |  ");

            d = DrawDisc(boardGrid[2, 4]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write("  |  ");

            d = DrawDisc(boardGrid[2, 5]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write("  |  ");

            d = DrawDisc(boardGrid[2, 6]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.WriteLine("  ||");


            // middle line - row 2
            Console.Write("| ");
            d = DrawDisc(boardGrid[2, 0]);
            Console.Write($"{d}{d}{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write(" | ");

            d = DrawDisc(boardGrid[2, 1]);
            Console.Write($"{d}{d}{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write(" | ");

            d = DrawDisc(boardGrid[2, 2]);
            Console.Write($"{d}{d}{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write(" | ");

            d = DrawDisc(boardGrid[2, 3]);
            Console.Write($"{d}{d}{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write(" | ");

            d = DrawDisc(boardGrid[2, 4]);
            Console.Write($"{d}{d}{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write(" | ");

            d = DrawDisc(boardGrid[2, 5]);
            Console.Write($"{d}{d}{d}{d}{d}"); ;
            Console.ForegroundColor = blue;
            Console.Write(" | ");

            d = DrawDisc(boardGrid[2, 6]);
            Console.Write($"{d}{d}{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.WriteLine(" ||");


            // bottom line - row 2
            Console.Write("|  ");
            d = DrawDisc(boardGrid[2, 0]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write("  |  ");

            d = DrawDisc(boardGrid[2, 1]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write("  |  ");

            d = DrawDisc(boardGrid[2, 2]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write("  |  ");

            d = DrawDisc(boardGrid[2, 3]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write("  |  ");

            d = DrawDisc(boardGrid[2, 4]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write("  |  ");

            d = DrawDisc(boardGrid[2, 5]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write("  |  ");

            d = DrawDisc(boardGrid[2, 6]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.WriteLine("  ||");

            //Console.WriteLine("|       |       |       |       |       |       |       ||");
            Console.WriteLine("|-------|-------|-------|-------|-------|-------|-------||");
            //Console.WriteLine("|       |       |       |       |       |       |       ||");


            // top line - row 3
            Console.Write("|  ");
            d = DrawDisc(boardGrid[3, 0]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write("  |  ");

            d = DrawDisc(boardGrid[3, 1]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write("  |  ");

            d = DrawDisc(boardGrid[3, 2]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write("  |  ");

            d = DrawDisc(boardGrid[3, 3]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write("  |  ");

            d = DrawDisc(boardGrid[3, 4]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write("  |  ");

            d = DrawDisc(boardGrid[3, 5]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write("  |  ");

            d = DrawDisc(boardGrid[3, 6]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.WriteLine("  ||");


            // middle line - row 3
            Console.Write("| ");
            d = DrawDisc(boardGrid[3, 0]);
            Console.Write($"{d}{d}{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write(" | ");

            d = DrawDisc(boardGrid[3, 1]);
            Console.Write($"{d}{d}{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write(" | ");

            d = DrawDisc(boardGrid[3, 2]);
            Console.Write($"{d}{d}{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write(" | ");

            d = DrawDisc(boardGrid[3, 3]);
            Console.Write($"{d}{d}{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write(" | ");

            d = DrawDisc(boardGrid[3, 4]);
            Console.Write($"{d}{d}{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write(" | ");

            d = DrawDisc(boardGrid[3, 5]);
            Console.Write($"{d}{d}{d}{d}{d}"); ;
            Console.ForegroundColor = blue;
            Console.Write(" | ");

            d = DrawDisc(boardGrid[3, 6]);
            Console.Write($"{d}{d}{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.WriteLine(" ||");


            // bottom line - row 3
            Console.Write("|  ");
            d = DrawDisc(boardGrid[3, 0]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write("  |  ");

            d = DrawDisc(boardGrid[3, 1]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write("  |  ");

            d = DrawDisc(boardGrid[3, 2]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write("  |  ");

            d = DrawDisc(boardGrid[3, 3]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write("  |  ");

            d = DrawDisc(boardGrid[3, 4]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write("  |  ");

            d = DrawDisc(boardGrid[3, 5]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write("  |  ");

            d = DrawDisc(boardGrid[3, 6]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.WriteLine("  ||");

            //Console.WriteLine("|       |       |       |       |       |       |       ||");
            Console.WriteLine("|-------|-------|-------|-------|-------|-------|-------||");
            //Console.WriteLine("|       |       |       |       |       |       |       ||");


            // top line - row 4
            Console.Write("|  ");
            d = DrawDisc(boardGrid[4, 0]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write("  |  ");

            d = DrawDisc(boardGrid[4, 1]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write("  |  ");

            d = DrawDisc(boardGrid[4, 2]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write("  |  ");

            d = DrawDisc(boardGrid[4, 3]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write("  |  ");

            d = DrawDisc(boardGrid[4, 4]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write("  |  ");

            d = DrawDisc(boardGrid[4, 5]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write("  |  ");

            d = DrawDisc(boardGrid[4, 6]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.WriteLine("  ||");


            // middle line - row 4
            Console.Write("| ");
            d = DrawDisc(boardGrid[4, 0]);
            Console.Write($"{d}{d}{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write(" | ");

            d = DrawDisc(boardGrid[4, 1]);
            Console.Write($"{d}{d}{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write(" | ");

            d = DrawDisc(boardGrid[4, 2]);
            Console.Write($"{d}{d}{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write(" | ");

            d = DrawDisc(boardGrid[4, 3]);
            Console.Write($"{d}{d}{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write(" | ");

            d = DrawDisc(boardGrid[4, 4]);
            Console.Write($"{d}{d}{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write(" | ");

            d = DrawDisc(boardGrid[4, 5]);
            Console.Write($"{d}{d}{d}{d}{d}"); ;
            Console.ForegroundColor = blue;
            Console.Write(" | ");

            d = DrawDisc(boardGrid[4, 6]);
            Console.Write($"{d}{d}{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.WriteLine(" ||");


            // bottom line  - row 4
            Console.Write("|  ");
            d = DrawDisc(boardGrid[4, 0]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write("  |  ");

            d = DrawDisc(boardGrid[4, 1]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write("  |  ");

            d = DrawDisc(boardGrid[4, 2]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write("  |  ");

            d = DrawDisc(boardGrid[4, 3]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write("  |  ");

            d = DrawDisc(boardGrid[4, 4]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write("  |  ");

            d = DrawDisc(boardGrid[4, 5]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write("  |  ");

            d = DrawDisc(boardGrid[4, 6]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.WriteLine("  ||");

            //Console.WriteLine("|       |       |       |       |       |       |       ||");
            Console.WriteLine("|-------|-------|-------|-------|-------|-------|-------||");

            // top line - row 5
            Console.Write("|  ");
            d = DrawDisc(boardGrid[5, 0]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write("  |  ");

            d = DrawDisc(boardGrid[5, 1]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write("  |  ");

            d = DrawDisc(boardGrid[5, 2]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write("  |  ");

            d = DrawDisc(boardGrid[5, 3]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write("  |  ");

            d = DrawDisc(boardGrid[5, 4]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write("  |  ");

            d = DrawDisc(boardGrid[5, 5]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write("  |  ");

            d = DrawDisc(boardGrid[5, 6]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.WriteLine("  ||");


            // middle line - row 5
            Console.Write("| ");
            d = DrawDisc(boardGrid[5, 0]);
            Console.Write($"{d}{d}{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write(" | ");

            d = DrawDisc(boardGrid[5, 1]);
            Console.Write($"{d}{d}{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write(" | ");

            d = DrawDisc(boardGrid[5, 2]);
            Console.Write($"{d}{d}{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write(" | ");

            d = DrawDisc(boardGrid[5, 3]);
            Console.Write($"{d}{d}{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write(" | ");

            d = DrawDisc(boardGrid[5, 4]);
            Console.Write($"{d}{d}{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write(" | ");

            d = DrawDisc(boardGrid[5, 5]);
            Console.Write($"{d}{d}{d}{d}{d}"); ;
            Console.ForegroundColor = blue;
            Console.Write(" | ");

            d = DrawDisc(boardGrid[5, 6]);
            Console.Write($"{d}{d}{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.WriteLine(" ||");


            // bottom line - row 5
            Console.Write("|  ");
            d = DrawDisc(boardGrid[5, 0]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write("  |  ");

            d = DrawDisc(boardGrid[5, 1]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write("  |  ");

            d = DrawDisc(boardGrid[5, 2]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write("  |  ");

            d = DrawDisc(boardGrid[5, 3]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write("  |  ");

            d = DrawDisc(boardGrid[5, 4]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write("  |  ");

            d = DrawDisc(boardGrid[5, 5]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.Write("  |  ");

            d = DrawDisc(boardGrid[5, 6]);
            Console.Write($"{d}{d}{d}");
            Console.ForegroundColor = blue;
            Console.WriteLine("  ||");

            Console.WriteLine("|_______|_______|_______|_______|_______|_______|_______||");
            Console.WriteLine("|-------|-------|-------|-------|-------|-------|-------||");
            Console.WriteLine();
        }
    }
}
