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

<<<<<<< HEAD
        //private void StartNewGame().  Message object should be send as paramenter here
        public void StartNewGame(Message output)
=======
        public void Run()
        {
            DisplayMainMenu();
            Console.ReadLine();
        }

        private void DisplayMainMenu()
        {
            Menu menu = new Menu(Menu.options);
            int selectedIndex = menu.Run();

            switch (selectedIndex)  //execution of program options.
            {
                case 0:
                    Console.Clear();
                    board.Initiate();
                    board.Display();
                    StartNewGame();
                    break;
                case 1:
                    // Change language

                    break;
                case 2:
                    // Exit game
                    Console.WriteLine("\nPress Enter to exit");  //note:  message as object
                    Console.ReadKey(true);
                    Environment.Exit(0);
                    break;
            }
        }

        //private void StartNewGame()
        private void StartNewGame()
>>>>>>> 8f3a01c74fc5a25ec3a98d3a121ce5f4db108016
        {
            MenuEnglish2 menu = new(); // Modified by Peter!
            board.Initiate();  //moving from Menu.  They should be in Game.**********
            board.Display();  // empty board 
            do
            {
<<<<<<< HEAD
                
                output.PlayerTurn("X");  //Console.Write($"Player playerName, your turn!\n");
                SelectColumn(output); // Modified by Peter!
=======
                Console.Write($"Player playerName, your turn!\n");  //note:  message as object
                SelectColumn();
>>>>>>> 8f3a01c74fc5a25ec3a98d3a121ce5f4db108016
                Console.Write("\n\n");
                board.Display();  // populated empty
                if (CheckForWinningMove('X') == true)
                {
<<<<<<< HEAD
                    
                    output.PlayerWins("X");  //Console.Write("\n\nPlayer X wins!\n\n");  
=======
                    Console.Write("\n\nPlayer X wins!\n\n");//note:  message as object

>>>>>>> 8f3a01c74fc5a25ec3a98d3a121ce5f4db108016
                    //playSound.Win();
                    Console.ReadKey(true); // Modified by Peter!
                    menu.MenuRun(); // Modified by Peter!

                    break;
                }
                else if (CheckForWinningMove('O') == true)
                {
<<<<<<< HEAD
                      
                    output.PlayerWins("O");  //Console.Write("\n\nPlayer O wins!\n\n");
=======
                    Console.Write("\n\nPlayer O wins!\n\n");//note:  message as object

>>>>>>> 8f3a01c74fc5a25ec3a98d3a121ce5f4db108016
                    //playSound.Win();
                    Console.ReadKey(true); // Modified by Peter!
                    menu.MenuRun(); // Modified by Peter!

                    break;
                }
            } while (true);
        }

        
        private void SelectColumn(Message output) // Modified by Peter!
        {
            MenuEnglish2 menu = new(); // Modified by Peter! 
            do
            {
                output.SelectColumn();    //Console.Write("\nChoose a column [1 to 7]: "); 
                string input = Console.ReadLine();
                int c = Int32.Parse(input);

                switch (c)
                {
                    case 0: // Modified by Peter!    
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

                        Console.ForegroundColor = ConsoleColor.Red;
<<<<<<< HEAD
                        
                        output.InvalidColumn();  //Console.Write("\nInvalid column selected! Try again.\n\n");
=======
                        Console.Write("\nInvalid column selected! Try again.\n\n");  //note:  message as object
>>>>>>> 8f3a01c74fc5a25ec3a98d3a121ce5f4db108016
                        Console.ResetColor();

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

<<<<<<< HEAD
        private bool CheckForWinningMove(char disc) //All moves should be objects.
=======
        private bool CheckForWinningMove(char disc)  //note:  implement as object
>>>>>>> 8f3a01c74fc5a25ec3a98d3a121ce5f4db108016
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
