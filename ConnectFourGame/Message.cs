using System;

namespace ConnectFourGame
{
    
    public abstract class Message
    {
        public static string[] options;

        // insert all future arrow functions alphabetically

        public virtual void ClearConsole() => Console.Clear();

        public virtual void ConsoleTitle() => Console.Title = "Connect Four Game";

        public virtual void BackgroundBlack() => Console.BackgroundColor = ConsoleColor.Black;

        public virtual void BackgroundBlue() => Console.BackgroundColor = ConsoleColor.Blue;

        public virtual void BackgroundWhite() => Console.BackgroundColor = ConsoleColor.White;

        public virtual void BackgroundRed() => Console.BackgroundColor = ConsoleColor.Red;

        public virtual void BackgroundYellow() => Console.BackgroundColor = ConsoleColor.Yellow;

        public virtual void DisplayCurrentOption(string currentOption) => Console.WriteLine($"<< {currentOption} >>");  //this should be writeline

        public virtual void EnterToExit() => Console.WriteLine("\nPress Enter to exit");

        public virtual void ForegroundBlack() => Console.ForegroundColor = ConsoleColor.Black;

        public virtual void ForegroundBlue() => Console.ForegroundColor = ConsoleColor.Blue;

        public virtual void ForegroundCyan() => Console.ForegroundColor = ConsoleColor.Cyan;

        public virtual void ForegroundDarkYellow() => Console.ForegroundColor = ConsoleColor.DarkYellow;

        public virtual void ForegroundGray() => Console.ForegroundColor = ConsoleColor.Gray;

        public virtual void ForegroundMagenta() => Console.ForegroundColor = ConsoleColor.Magenta;

        public virtual void ForegroundRed() => Console.ForegroundColor = ConsoleColor.Red;

        public virtual void ForegroundWhite() => Console.ForegroundColor = ConsoleColor.White;

        public virtual void ForegroundYellow() => Console.ForegroundColor = ConsoleColor.Yellow;

        public virtual void InvalidColumn() => this.Write("\nInvalid column selected! Try again.\n\n");

        public virtual void PlayerTurn(string playerName)
        {
            if (playerName == "X")
            {
                playerName = "Red";
            }
            else if (playerName == "O")
            {
                playerName = "Yellow";
            }
            Console.Write($"{playerName} player, your turn!\n");
        }

        public virtual void Spaces() => Console.WriteLine("\n\n");

        public virtual void ReadKey() => Console.ReadKey(true);

        public virtual void RecurrentInputError() => Console.Write("\n\nInput error: use numbers from 1 - 7 only.\n");

        public virtual void ResetColor() => Console.ResetColor();

        public virtual void Write(string element) => Console.Write(element);

        public virtual void WriteLine(string element) => Console.WriteLine(element);

        public virtual void PlayerWins(string playerName) //object should be sent here
        {
            this.Write("\n");

            if (playerName == "X")
            {
                playerName = "Red";
                this.ForegroundRed();
            }
            else if (playerName == "O")
            {
                playerName = "Yellow";
                this.ForegroundYellow();
            }

            this.Write(playerName);
            this.ForegroundBlue();
            this.Write(" player wins!");
        }

        public virtual void SelectColumn()
        {
            this.Write("\nEnter [0] to return to Main Menu");
            this.Write("\nChoose a column [1 to 7]: ");
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
