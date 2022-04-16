using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFourGame 
{
    public abstract class Board : BoardInterface
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

        public abstract void Initiate();

        public abstract void SetColor(char c);

        public abstract void Display();
    }
}
