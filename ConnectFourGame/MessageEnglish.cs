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

        public override void EnterToExit() => base.EnterToExit();

        public override void ClearConsole() => base.ClearConsole();

        public override void PlayerTurn(string playerName) => base.PlayerTurn(playerName);

        public override void PlayerWins(string playerName)  => base.PlayerWins(playerName);

        public override void SelectColumn() => base.SelectColumn();

        public override void InvalidColumn() => base.InvalidColumn();

        public override void ConsoleTitle() => base.ConsoleTitle();

        public override void ForegroundBlack() => base.ForegroundBlack();

        public override void ForegroundWhite() => base.ForegroundWhite();

        public override void ForegroundYellow() => base.ForegroundYellow();

        public override void ForegroundRed() => base.ForegroundRed();

        public override void ForegroundBlue() => base.ForegroundBlue();

        public override void BackgroundBlack() => base.BackgroundBlack();

        public override void BackgroundWhite() => base.BackgroundWhite();

        public override void BackgroundYellow() => base.BackgroundYellow();

        public override void BackgroundRed() => base.BackgroundRed();

        public override void BackgroundBlue() => base.BackgroundBlue();

        public override void ResetColor() => base.ResetColor();        

        public override void DisplayCurrentOption(string currentOption) => Console.WriteLine($"<< {currentOption} >>"); //this should be writeline

        public override void Spaces() => this.Write("\n\n");

        public override void Write(string element) => Console.Write(element);

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
            base.ForegroundYellow();
            this.Write(title);
            base.ResetColor();

        }

    }
}
