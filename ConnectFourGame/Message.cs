using System;

namespace ConnectFourGame
{
    
    public abstract class Message
    {
        public static string[] options;

        public virtual void EnterToExit()
        {
            Console.WriteLine("\nPress Enter to exit");
        }

        public virtual void ClearConsole()
        {
           Console.Clear();
        }

        public virtual void PlayerTurn()
        {
            Console.Clear();
        }

        public virtual void PlayerTurn(string playerName)
        {
            Console.Write($"Player {playerName}, your turn!\n");
        }

        public virtual void PlayerWins(string playerName) //object should be sent here
        {
            //Console.WriteLine($"Player {playerName} wins!");
            ConsoleColor red = ConsoleColor.Red;
            ConsoleColor yellow = ConsoleColor.Yellow;
            ConsoleColor blue = ConsoleColor.Blue;

            Console.Write("\nPlayer ");

            if (playerName == "X")
            {
                Console.ForegroundColor = red;
            }
            else if (playerName == "O")
            {
                Console.ForegroundColor = yellow;
            }
            
            Console.Write(playerName);

            Console.ForegroundColor = blue;

            Console.Write(" wins!");
        }

        public virtual void SelectColumn() 
        {
            Console.Write("\nEnter [0] to return to Main Menu");
            Console.Write("\nChoose a column [1 to 7]: ");
        }

        public virtual void InvalidColumn()
        {
            Console.Write("\nInvalid column selected! Try again.\n\n");
        }

        public virtual string[] MenuOptions()
        {
            options = new string[] { "Game options" };
            return options;
            
        }

        public virtual void MaintTitle()
        {
            string title = @"   ______                            __     ______                    ______                   
  / ____/___  ____  ____  ___  _____/ /_   / ____/___  __  _______   / ____/___ _____ ___  ___ 
 / /   / __ \/ __ \/ __ \/ _ \/ ___/ __/  / /_  / __ \/ / / / ___/  / / __/ __ `/ __ `__ \/ _ \
/ /___/ /_/ / / / / / / /  __/ /__/ /_   / __/ / /_/ / /_/ / /     / /_/ / /_/ / / / / / /  __/
\____/\____/_/ /_/_/ /_/\___/\___/\__/  /_/    \____/\__,_/_/      \____/\__,_/_/ /_/ /_/\___/                                                                                                                                                                                                                                 
";
            Console.ForegroundColor = ConsoleColor.Yellow;  
            Console.WriteLine(title);
            Console.ResetColor();
        }

        public virtual void ConsoleTitle()
        {
            Console.Title = "Connect Four Game";
        }

        public virtual void  ForegroundBlack()
        {
            Console.ForegroundColor = ConsoleColor.Black;
        }

        public virtual void ForegroundWhite()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }

        public virtual void ForegroundYellow()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }

        public virtual void BackgroundBlack()
        {
            Console.BackgroundColor = ConsoleColor.Black;
        }

        public virtual void BackgroundWhite()
        {
            Console.BackgroundColor = ConsoleColor.White;
        }

        public virtual void BackgroundYellow()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
        }

        public virtual void ResetColor()
        {
            Console.ResetColor();
        }

        public virtual void DisplayCurrentOption(string currentOption)
        {
            Console.WriteLine($"<< {currentOption} >>");
        }


    }
}
