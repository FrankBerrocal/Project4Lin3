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
        private Message output = new MessageEnglish(); //creates a message object.
        
        private int SelectedIndex;
        private string[] Options;
<<<<<<< HEAD
        //private string[] Languages;
       


        public Menu()
=======
        public static string[] options = new string[] { "Play Game", "Change Language", "Exit Game" };  //menu options

        public Menu(string[] options)  //options should be passed as part of the constructor.   
>>>>>>> 8f3a01c74fc5a25ec3a98d3a121ce5f4db108016
        {
            Options = output.MenuOptions();  //brings the menu options from the message object           
        }


<<<<<<< HEAD
        public virtual void DisplayOptions()  //public access methods
=======
        private void DisplayOptions()  //suitable for child class, create parent class for theric purposes.
>>>>>>> 8f3a01c74fc5a25ec3a98d3a121ce5f4db108016
        {

            output.MaintTitle();
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
                    
                    output.ForegroundBlack();
                    output.BackgroundWhite();
                }
                else
                {
                    
                    output.ForegroundYellow();
                    output.BackgroundBlack();

                }

                output.DisplayCurrentOption(currentOption);
                output.ResetColor();
            }
        }

<<<<<<< HEAD
        private int KeyListener(ConsoleKey keyPressed)  //private helper methods
=======

        public int Run()  //describe in parent as abstract.  
>>>>>>> 8f3a01c74fc5a25ec3a98d3a121ce5f4db108016
        {
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
            return SelectedIndex;


        }
        //local processing
        private void CommandProcessing(int SelectedIndex)  //private helper methods
        {
            switch (SelectedIndex)  //execution of program options.
            {
                case 0:
                    Message outputEng = new MessageEnglish();
                    output.ClearConsole();
                    game.StartNewGame(outputEng); // Modified by Peter!

                    break;
                case 1:
                    // Change language
                    Message outputEsp = new MessageSpanish();
                    output.ClearConsole();
                    game.StartNewGame(outputEsp); // Modified by Peter!

                    break;
                case 2:
                    // TODO
                    // Change Game Mode from Standard to Retro
                    Environment.Exit(0); // Modified by Peter!

                    break;
                case 3:
                    // Exit Game
                    Environment.Exit(0); // Modified by Peter!

                    break;
            }

        }
    }

}
