using System;

namespace ConnectFourGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Main entry to the Connect Four Game App

           Console.Title = "Connect Four Game";

            Message mes = new MessageEnglish();
            MenuEnglish2 menu = new();

            mes.ConsoleTitle();
            menu.MenuRun();

        }

    }
}
