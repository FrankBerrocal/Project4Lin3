using System;

namespace ConnectFourGame
{
    
    public abstract class Message
    {
        public static string[] options;

        public virtual void EnterToExit() => Console.WriteLine("\nPress Enter to exit");

        public virtual void ClearConsole() => Console.Clear();

        public virtual void PlayerTurn() => Console.Clear();

        public virtual void PlayerTurn(string playerName) => Console.Write($"Player {playerName}, your turn!\n");

        public virtual void ConsoleTitle() => Console.Title = "Connect Four Game";

        public virtual void ForegroundBlack() => Console.ForegroundColor = ConsoleColor.Black;

        public virtual void ForegroundWhite() => Console.ForegroundColor = ConsoleColor.White;

        public virtual void ForegroundYellow() => Console.ForegroundColor = ConsoleColor.Yellow;

        public virtual void ForegroundRed() => Console.ForegroundColor = ConsoleColor.Red;

        public virtual void ForegroundBlue() => Console.ForegroundColor = ConsoleColor.Blue;

        public virtual void BackgroundBlack() => Console.BackgroundColor = ConsoleColor.Black;

        public virtual void BackgroundWhite() => Console.BackgroundColor = ConsoleColor.White;

        public virtual void BackgroundYellow() => Console.BackgroundColor = ConsoleColor.Yellow;

        public virtual void BackgroundRed() => Console.BackgroundColor = ConsoleColor.Red;

        public virtual void BackgroundBlue() => Console.BackgroundColor = ConsoleColor.Blue;

        public virtual void ResetColor() => Console.ResetColor();

        public virtual void DisplayCurrentOption(string currentOption) => Console.WriteLine($"<< {currentOption} >>");  //this should be writeline

        public virtual void Spaces() => Console.WriteLine("\n\n");

        public virtual void ReadKey() => Console.ReadKey(true);

        public virtual void Write(string element) => Console.Write(element);

        public virtual void PlayerWins(string playerName) //object should be sent here
        {

            this.Write("\nPlayer ");

            if (playerName == "X")
            {
                this.ForegroundRed();

            }
            else if (playerName == "O")
            {
                this.ForegroundYellow();

            }

            this.Write(playerName);
            this.ForegroundBlue();
            this.Write(" wins!");
        }

        public virtual void SelectColumn()
        {
            this.Write("\nEnter [0] to return to Main Menu");
            this.Write("\nChoose a column [1 to 7]: ");
        }

        public virtual void InvalidColumn()
        {
            this.Write("\nInvalid column selected! Try again.\n\n");
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

            this.ForegroundYellow();
            this.Write(title);
            this.ResetColor();

        }


    }
}
