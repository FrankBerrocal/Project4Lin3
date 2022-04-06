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

        public void Run()
        {
            DisplayMainMenu();
            Console.ReadLine();
        }

        private void DisplayMainMenu()
        {
            Menu menu = new Menu(Menu.options);
            int selectedIndex = menu.Run();

            switch (selectedIndex)
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
                    Console.WriteLine("\nPress Enter to exit");
                    Console.ReadKey(true);
                    Environment.Exit(0);
                    break;
            }
        }

        //private void StartNewGame()

        //private void SelectColumn()

        //private void DropDisc()

        //private bool CheckForWinningMove(char disc)
    }
}
