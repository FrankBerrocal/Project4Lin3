using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFourGame
{
    public class Game
    {
        // Main game logic here
        Board board = new Board();
        Message output = new MessageEnglish();

        //private void StartNewGame().  Message object should be send as paramenter here
        public void StartNewGame(Message output)
        {
            MenuEnglish menu = new(); 
            board.Initiate();  //moving from Menu.  They should be in Game.**********
            board.Display();  // empty board 
            do
            {
                
                output.PlayerTurn("X");  //Console.Write($"Player playerName, your turn!\n");
                SelectColumn(output);
                output.Spaces();
                //Console.Write("\n\n");
                board.Display();  // populated empty
                if (CheckForWinningMove('X') == true)
                {
                    
                    output.PlayerWins("X");  //Console.Write("\n\nPlayer X wins!\n\n");  
                    //playSound.Win();
                    //Console.ReadKey(true);
                    output.ReadKey();
                    menu.MenuRun(); 

                    break;
                }
                else if (CheckForWinningMove('O') == true)
                {
                      
                    output.PlayerWins("O");  //Console.Write("\n\nPlayer O wins!\n\n");
                    //playSound.Win();
                    //Console.ReadKey(true);
                    output.ReadKey();
                    menu.MenuRun(); 

                    break;
                }
            } while (true);
        }

        
        private void SelectColumn(Message output) 
        {
            MenuEnglish menu = new(); 
            do
            {
                output.SelectColumn();    //Console.Write("\nChoose a column [1 to 7]: "); 
                string input = Console.ReadLine();
                int c = Int32.Parse(input);

                switch (c)
                {
                    case 0:    
                        menu.MenuRun(); // Takes player back to the Main Menu
                        break;
                    case 1:
                        board.selectedColumn = 0;
                        break;
                    case 2:
                        board.selectedColumn = 1;
                        break;
                    case 3:
                        board.selectedColumn = 2;
                        break;
                    case 4:
                        board.selectedColumn = 3;
                        break;
                    case 5:
                        board.selectedColumn = 4;
                        break;
                    case 6:
                        board.selectedColumn = 5;
                        break;
                    case 7:
                        board.selectedColumn = 6;
                        break;
                    default:
                        board.selectedColumn = 666;

                        //Console.ForegroundColor = ConsoleColor.Red;
                        output.ForegroundRed();
                        
                        output.InvalidColumn();  //Console.Write("\nInvalid column selected! Try again.\n\n");
                        output.ResetColor();
                        //Console.ResetColor();

                        //playSound.Wrong();

                        board.Display();
                        break;
                }

                if ((board.selectedColumn >= 0 && board.selectedColumn <= 6) && (board.boardGrid[0, board.selectedColumn] == ' '))
                {
                    DropDisc();
                    Board.disc = (Board.disc == 'X') ? 'O' : 'X';
                    break;
                }

            } while (true);
        }

        //private void DropDisc()
        private void DropDisc()
        {
            int ROWS = Board.Rows;
            char disc = Board.disc;
            int level;

            for (level = ROWS - 1; level >= 0; level--)
            {
                if (board.boardGrid[level, board.selectedColumn] == ' ')
                {
                    board.boardGrid[level, board.selectedColumn] = disc;

                    //playSound.Drop();

                    break;
                }
            }
        }

        private bool CheckForWinningMove(char disc) //All moves should be objects.
        {
            int ROWS = Board.Rows;
            int COLS = Board.Columns;



            // check HORIZONTAL slots for a winning move
            for (int c = 0; c < COLS - 3; c++)
            {
                for (int r = 0; r < ROWS; r++)
                {
                    if (board.boardGrid[r, c] == disc && board.boardGrid[r, c + 1] == disc && board.boardGrid[r, c + 2] == disc && board.boardGrid[r, c + 3] == disc)
                    {
                        return true;
                    }
                }
            }


            // check VERTICAL slots for a winning move
            for (int c = 0; c < COLS; c++)
            {
                for (int r = 0; r < ROWS - 3; r++)
                {
                    if (board.boardGrid[r, c] == disc && board.boardGrid[r + 1, c] == disc && board.boardGrid[r + 2, c] == disc && board.boardGrid[r + 3, c] == disc)
                    {
                        return true;
                    }
                }
            }


            // check POSITIVE SLOPE DIAGONAL slots for a winning move
            for (int c = 0; c < COLS - 3; c++)
            {
                for (int r = 0; r < ROWS - 3; r++)
                {
                    if (board.boardGrid[r, c] == disc && board.boardGrid[r + 1, c + 1] == disc && board.boardGrid[r + 2, c + 2] == disc && board.boardGrid[r + 3, c + 3] == disc)
                    {
                        return true;
                    }
                }
            }


            // check NEGATIVE SLOPE DIAGONAL slots for a winning move
            for (int c = 0; c < COLS - 3; c++)
            {
                for (int r = 3; r < ROWS; r++)
                {
                    if (board.boardGrid[r, c] == disc && board.boardGrid[r - 1, c + 1] == disc && board.boardGrid[r - 2, c + 2] == disc && board.boardGrid[r - 3, c + 3] == disc)
                    {
                        return true;
                    }
                }
            }
            return false;
        }


    }
}
