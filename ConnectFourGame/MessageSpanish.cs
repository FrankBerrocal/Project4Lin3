using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFourGame
{
    public class MessageSpanish : Message
    {
        public MessageSpanish()
        {
            //empty constructor
        }

        // insert all future arrow functions alphabetically

        public override void ClearConsole() => base.ClearConsole();

        public override void ConsoleTitle() => Console.Title = "Juego Cuatro en Linea";

        public override void BackgroundBlack() => base.BackgroundBlack();

        public override void BackgroundWhite() => base.BackgroundWhite();

        public override void BackgroundYellow() => base.BackgroundYellow();

        public override void BackgroundRed() => base.BackgroundRed();

        public override void DisplayCurrentOption(string currentOption) => Console.WriteLine($"<< {currentOption} >>"); //this should be writeline

        public override void EnterToExit() => this.Write("\nPresione Enter para Salir");

        public override void ForegroundBlack() => base.ForegroundBlack();

        public override void ForegroundBlue() => Console.ForegroundColor = ConsoleColor.Blue;

        public override void ForegroundCyan() => Console.ForegroundColor = ConsoleColor.Cyan;

        public override void ForegroundDarkYellow() => Console.ForegroundColor = ConsoleColor.DarkYellow;

        public override void ForegroundGray() => Console.ForegroundColor = ConsoleColor.Gray;

        public override void ForegroundMagenta() => Console.ForegroundColor = ConsoleColor.Magenta;

        public override void ForegroundRed() => base.ForegroundRed();

        public override void ForegroundWhite() => base.ForegroundWhite();

        public override void ForegroundYellow() => base.ForegroundYellow();

        public override void InvalidColumn() => this.Write("\nColumna seleccionada no es valida! Intenta de nuevo.\n\n");

        public override void PlayerTurn(string playerName) => this.Write($"Jugador {playerName}, es su turno!\n");

        public override void ReadKey() => base.ReadKey();

        public override void RecurrentInputError() => Console.Write("\n\nError de entrada: use numeros de 1 - 7.\n");

        public override void ResetColor() => base.ResetColor();

        public override void Spaces() => base.Spaces();

        public override void Write(string element) => Console.Write(element);

        public override void WriteLine(string element) => Console.WriteLine(element);


        public override void PlayerWins(string playerName) //object should be sent here
        {

            this.Write("\nJugador ");

            if (playerName == "X")
            {
                base.ForegroundRed();  //properties should be part of object.

            }
            else if (playerName == "O")
            {
                base.ForegroundYellow();

            }

            this.Write(playerName);
            base.ForegroundBlue();
            this.Write(" gana!");

        }

        public override void SelectColumn()
        {
            this.Write("\nIngrese[0] para regresar al menú principal");
            this.Write("\nEscoja una columna [1 a 7]: ");

        }

        public override string[] MenuOptions()
        {
            options = new string[] { "Jugar", "Cambiar Lenguaje", "Salir del Juego" };
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
