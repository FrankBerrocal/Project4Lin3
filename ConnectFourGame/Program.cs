using System;

namespace ConnectFourGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Main entry to the Connect Four Game App

            Console.Title = "Connect Four Game";

            Game game = new Game();
            game.Run();
        }
    }
}
