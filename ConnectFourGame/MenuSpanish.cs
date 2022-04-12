using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFourGame
{
    public class MenuSpanish : Menu
    {
        

        
        private Game game = new Game();
        private Message output = new MessageSpanish(); //creates a message object.
        private int SelectedIndex;
        private string[] Options;
        

        
        public MenuSpanish()
        {
            Options = output.MenuOptions();  //brings the menu options from the message object           

        }


        public override void DisplayOptions()
        {
            
            output.MaintTitle();


            for (int i = 0; i < Options.Length; i++)
            {
                string currentOption = Options[i];

                if (i == SelectedIndex)  //change menu option color with selection.
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.BackgroundColor = ConsoleColor.Black;
                }

                Console.WriteLine($"<< {currentOption} >>");

                Console.ResetColor();
            }
           
        }


        public override void MenuRun()
        {
            

            ConsoleKey keyPressed;
            

            do
            {
                output.ClearConsole();
                DisplayOptions();

                ConsoleKeyInfo keyInfo = Console.ReadKey(true); //reads interaction from the console
                keyPressed = keyInfo.Key; //listens to any key pressed

                // Update SelectedIndex based on arrow keys.

                if (keyPressed == ConsoleKey.UpArrow)  //if key pressed is arrow
                {
                    SelectedIndex--;
                    if (SelectedIndex == -1)
                    {
                        SelectedIndex = 0;
                        
                    }
                }
                else if (keyPressed == ConsoleKey.DownArrow)
                {
                    SelectedIndex++;
                    if (SelectedIndex == Options.Length)
                    {
                        SelectedIndex = Options.Length - 1;
                        
                        
                    }
                }

            } while (keyPressed != ConsoleKey.Enter);


            switch (SelectedIndex)  //execution of program options.
            {
                case 0:
                    output.ClearConsole();

                   // game.StartNewGame();
                    break;
                case 1:
                    // Change language

                    break;
                case 2:
                    // Exit game
                    //Console.WriteLine("\nPress Enter to exit");    //this should be object
                    output.ClearConsole();
                    Console.ReadKey(true); //what is the purpose of this readkey here?
                    Environment.Exit(0);
                    break;
            }
        }
    }

}
