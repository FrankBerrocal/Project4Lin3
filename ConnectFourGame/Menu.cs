using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFourGame
{
    public abstract class Menu : MenuInterface
    {
        
        private Game game = new();
        private Message Output = new MessageEnglish(); //creates a message object.
        
        private int SelectedIndex;
        private string[] Options;
        //private string[] Languages;
       


        public Menu()
        {
            Options = Output.MenuOptions();  //brings the menu options from the message object           
        }


        public virtual void DisplayOptions()  //public access methods
        {

            Output.MaintTitle();
            DisplayOptionsProcessing(Options);  //processing methods are private.

        }


        public virtual void MenuRun()
        {

            //SelectedIndex = 0;
            ConsoleKey keyPressed = 0;
            SelectedIndex = KeyListener(keyPressed);
            CommandProcessing(SelectedIndex);  //processing methods are private.

        }

        private void DisplayOptionsProcessing(string[] Options)  //private helper methods.
        {
            
            for (int i = 0; i < Options.Length; i++)  //process the array sent
            {
                string currentOption = Options[i];

                if (i == SelectedIndex)  //change menu option color with selection.
                {
                    
                    Output.ForegroundBlack();
                    Output.BackgroundWhite();
                }
                else
                {
                    
                    Output.ForegroundYellow();
                    Output.BackgroundBlack();

                }

                Output.DisplayCurrentOption(currentOption);
                Output.ResetColor();
            }
        }

        private int KeyListener(ConsoleKey keyPressed)  //private helper methods
        {
            do
            {
                Output.ClearConsole();
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
            return SelectedIndex;


        }
        //local processing
        private void CommandProcessing(int SelectedIndex)  //private helper methods
        {
            switch (SelectedIndex)  //execution of program options.
            {
                case 0:
                    Message outputEng = new MessageEnglish();
                    Output.ClearConsole();
                    game.StartNewGame(outputEng); 

                    break;
                case 1:
                    // Change language
                    Message outputEsp = new MessageSpanish();
                    Output.ClearConsole();
                    game.StartNewGame(outputEsp); 

                    break;
                case 2:
                    // TODO
                    // Change Game Mode from Standard to Retro
                    Environment.Exit(0); 

                    break;
                case 3:
                    // Exit Game
                    Environment.Exit(0); 

                    break;
            }

        }
    }

}
