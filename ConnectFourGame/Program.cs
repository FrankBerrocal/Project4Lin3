using System;

namespace ConnectFourGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Mac!");

<<<<<<< Updated upstream
            Console.WriteLine("Hello Windows");
=======
           Console.Title = "Connect Four Game";

            Message mes = new MessageEnglish();
            MenuEnglish2 menu = new();

            mes.ConsoleTitle();
            menu.MenuRun();

>>>>>>> Stashed changes
        }

    }
}
