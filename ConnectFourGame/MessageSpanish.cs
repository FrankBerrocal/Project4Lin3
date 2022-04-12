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

        public override void EnterToExit()
        {
            Console.WriteLine("\nPresione Enter para Salir");
        }

        public override void ClearConsole()
        {
            Console.Clear();
        }

        public override void PlayerTurn(string playerName)
        {
            Console.Write($"Jugador{playerName}, es su turno!\n");
        }

        public override void PlayerWins(string playerName)
        {
            Console.WriteLine($"Jugador {playerName} gana!");
        }

        public override void SelectColumn()
        {
            Console.Write("\nEscoja una columna [1 a 7]: ");
        }

        public override void InvalidColumn()
        {
            Console.Write("\nColumna seleccionada no es valida! Intenta de nuevo.\n\n");
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
            Console.ForegroundColor = ConsoleColor.Yellow;  
            Console.WriteLine(title);
            Console.ResetColor();
        }

        public override void ConsoleTitle()
        {
            Console.Title = "Juego Cuatro en Linea";
        }

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

        public override string[] LanguageOptions()
        {
            options = new string[] {"Español", "English"};
            return options;

        }

    }
}
