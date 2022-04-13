using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFourGame
{
    public class MessageEnglish : Message
    {
        public MessageEnglish()
        {
            //empty constructor
        }

        public override void EnterToExit()
        {
            //Console.WriteLine("\nPress Enter to exit");
            base.EnterToExit();
        }

        public override void ClearConsole()
        {
            //Console.Clear();
            base.ClearConsole();
        }

        public override void PlayerTurn(string playerName)
        {
            //Console.Write($"Player {playerName}, your turn!\n");
            base.PlayerTurn(playerName);
        }

        public override void PlayerWins(string playerName)  //object should be sent here
        {
            //Console.WriteLine($"Player {playerName} wins!");
            base.PlayerWins(playerName);
           
        }

        public override void SelectColumn()
        {
            //Console.Write("\nChoose a column [1 to 7]: ");
            base.SelectColumn();
        }

        public override void InvalidColumn()
        {
            //Console.Write("\nInvalid column selected! Try again.\n\n");
            base.InvalidColumn();
        }

        public override string[] MenuOptions()
        {
            options = new string[] { "Play in English", "Jugar en español", "Game Mode: Standard", "Exit Game" };
            return options;

        }

        public override void MaintTitle()
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

        public override void ConsoleTitle() => base.ConsoleTitle();

        public override void ForegroundBlack() => base.ForegroundBlack();

        public override void ForegroundWhite() => base.ForegroundWhite();

        public override void ForegroundYellow() => base.ForegroundYellow();

        public override void BackgroundBlack() => base.BackgroundBlack();

        public override void BackgroundWhite() => base.BackgroundWhite();

        public override void BackgroundYellow() => base.BackgroundYellow();

        public override void ResetColor() => base.ResetColor();        
       

        public override void DisplayCurrentOption(string currentOption)
        {
            Console.WriteLine($"<< {currentOption} >>");
        }

    }
}
