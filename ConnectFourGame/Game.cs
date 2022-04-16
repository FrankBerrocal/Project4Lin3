using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConnectFourGame
{
    public class Game
    {
        public void StartNewGame(Message output, Board boardType)
        {
            Board board = boardType;
            MenuEnglish menu = new();

            Player player1 = new Player("X", output);  //Definition of player properties, sending name and object message
            Player player2 = new Player("O", output);

            board.Initiate();  
            board.Display();  // empty board
            try
            {
                Processing(player1, player2, output, menu, boardType);  //processing code converted to helper to handle exceptions
            }

            catch (FormatException)  //Specific exception
            {
                output.ForegroundGray();
                output.InvalidColumn();
                output.ForegroundBlue();
                board.Initiate();
                board.Display();
                Processing(player1, player2, output, menu, boardType);
            }
            catch (Exception)  //generic exception
            {
                output.ForegroundGray();
                output.InvalidColumn();
                output.ForegroundBlue();
                board.Initiate();
                board.Display();
                Processing(player1, player2, output, menu, boardType);
            }
            finally
            {
                
               
               output.RecurrentInputError();
               menu.DisplayOptions();
            }
        }

        private void Processing(Player player1, Player player2, Message output, Menu menu, Board boardType)
        {
            Board board = boardType;
            

            do
            {
                //validation for the player turn should be made here.  The second validation should be made with player2
                //player1.DisplayPlayerColorYellow();  //change the color of foreground for the object.
                //output.PlayerTurn(player1.ToString());  //Display the name of the object.
                                                        //until here for object manipulation

                if (Board.disc == 'X')
                {
                    // Player X your turn
                    player1.DisplayPlayerColorRed();
                    output.PlayerTurn(player1.ToString());
                }
                else if (Board.disc == 'O')
                {
                    // Player O your turn
                    player2.DisplayPlayerColorYellow();
                    output.PlayerTurn(player2.ToString());
                }


                output.ForegroundBlue();
                SelectColumn(output, boardType);
                output.Spaces();

                board.Display();  // populated empty

                if (CheckForWinningMove(char.Parse(player1.ToString()), boardType) == true)  //name is converted to char for validation
                {

                    output.PlayerWins(player1.ToString()); //name presented in the message
                    //playSound.Win();

                    output.ReadKey();
                    menu.MenuRun();

                    break;
                }
                else if (CheckForWinningMove(char.Parse(player2.ToString()), boardType) == true) //name is converted to char for validation
                {

                    output.PlayerWins(player2.ToString());  //name presented in the message
                    //playSound.Win();

                    output.ReadKey();
                    menu.MenuRun();

                    break;
                }
            } while (true);
        }

        
        private void SelectColumn(Message output, Board boardType) 
        {
            Board board = boardType;
            MenuEnglish menu = new();
            int capture;
            do
            {
                output.SelectColumn();    
                string input = Console.ReadLine();
                try
                {
                    capture = Int32.Parse(input);
                }
                catch(SystemException)
                {
                    
                    board.Display();
                    capture = 666; //if the input is non numeric, column one is chosen.
                    output.ForegroundRed();
                    output.RecurrentInputError();
                    output.ForegroundBlue();
                }
                
                

                switch (capture)
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
                        output.ForegroundRed();
                        output.InvalidColumn();  
                        output.ResetColor();
                        
                        //playSound.Wrong();

                        board.Display();
                        break;
                }

                if ((board.selectedColumn >= 0 && board.selectedColumn <= 6) && (board.boardGrid[0, board.selectedColumn] == ' '))
                {
                    DropDisc(boardType);
                    Board.disc = (Board.disc == 'X') ? 'O' : 'X';
                    break;
                }
                else
                {
                    output.ForegroundRed();
                    output.InvalidColumn();
                    output.ForegroundBlue();
                    break;
                }

            } while (true);
        }

        //private void DropDisc()
        private void DropDisc(Board boardType)
        {
            Board board = boardType;
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

        private bool CheckForWinningMove(char disc, Board boardType) //All moves should be objects.
        {
            Board board = boardType;
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
