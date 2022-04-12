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
<<<<<<< Updated upstream
        public static string[] options = new string[] { "Play Game", "Change Language", "Exit Game" };

        public Menu(string[] options)
=======
        private string[] Languages;
       


        public Menu()
>>>>>>> Stashed changes
        {
            Options = output.MenuOptions();  //brings the menu options from the message object           
        }


        public virtual void DisplayOptions()  //public access methods
        {

            output.MaintTitle();
            DisplayOptionsProcessing(Options);  //processing methods are private.

        }

<<<<<<< Updated upstream
        
        private void DisplayOptions()
        {
            string title = @"   ______                            __     ______                    ______                   
  / ____/___  ____  ____  ___  _____/ /_   / ____/___  __  _______   / ____/___ _____ ___  ___ 
 / /   / __ \/ __ \/ __ \/ _ \/ ___/ __/  / /_  / __ \/ / / / ___/  / / __/ __ `/ __ `__ \/ _ \
/ /___/ /_/ / / / / / / /  __/ /__/ /_   / __/ / /_/ / /_/ / /     / /_/ / /_/ / / / / / /  __/
\____/\____/_/ /_/_/ /_/\___/\___/\__/  /_/    \____/\__,_/_/      \____/\__,_/_/ /_/ /_/\___/                                                                                                                                                                                                                                 
";
            Console.ForegroundColor = ConsoleColor.Yellow;  //background color
            Console.WriteLine(title);
            Console.ResetColor();

            for (int i = 0; i < Options.Length; i++)
=======

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
>>>>>>> Stashed changes
            {
                string currentOption = Options[i];

                if (i == SelectedIndex)
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
        

<<<<<<< Updated upstream
        public int Run()
=======
        private int KeyListener(ConsoleKey keyPressed)  //private helper methods
>>>>>>> Stashed changes
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
                    //Message output2 = new MessageSpanish();
                    output.ClearConsole();
                    game.StartNewGame(output);

                    break;
                case 1:
                    // Change language
                    try
                    {
                        //Peter I need you to advance on this, here my notes.  The game is not affected, this should select either english or spanish in your interface.
                        /*
                        SelectedIndex = 0;
                        output.ClearConsole();
                        Languages = output.LanguageOptions();  //call the object method Language Options
                        DisplayOptionsProcessing(Languages); //call helper DisplayOptionsProcessing, receiving the array as parameter. Paint the options.   Index error
                        ConsoleKey keyPressed = 0; //save the keyPressed listener.
                        SelectedIndex = KeyListener(keyPressed);  //this is sending to processing of the arrows used.
                        */

                        //functional example
                        /*
                        Console.WriteLine("Select 0. English, 1. Spanish");
                        int selection = Console.Read();
                        selection = int.Parse(selection);
                        Console.WriteLine("this is selection "+selection);
                        */

                        //LanguageProcessing(selection);

                    }
                    catch(IndexOutOfRangeException)
                    {
                        Console.WriteLine("Error in index");
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        Console.WriteLine("Error in argument");
                    }
                    finally
                    {
                        Console.WriteLine("No execution");
                    }

                    break;
                case 2:
                    // Exit game
                    //Console.WriteLine("\nPress Enter to exit");    //this should be object
                    output.ClearConsole();
                    //Console.ReadKey(true); //what is the purpose of this readkey here?
                    Environment.Exit(0);
                    break;
            }

        }

        private void LanguageProcessing(int selection)  //private helper methods
        {
            //here SelectedIndex is sending 49.  I believe you know that error.
            switch (selection)  //execution of program options.
            {
                case 0:

                    output.ClearConsole();
                    Console.WriteLine("This is English");
                    _ = new MessageEnglish();
                    game.StartNewGame(output);  //starting the game with messages in English
                    

                    break;
                case 1:
                    
                    output.ClearConsole();
                    Console.WriteLine("This is Spanish");
                    _ = new MessageSpanish();
                    game.StartNewGame(output);  //starting the game with messages in Spanish
                    

                    break;
                default:
                    Console.WriteLine("error in the switch");
                    
                    break;
            }

        }

    }

}
