using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFourGame
{
    public class Menu
    {
        // Main Menu here
        
        private int SelectedIndex;
        private string[] Options;
        public static string[] options = new string[] { "Play Game", "Change Language", "Exit Game" };

        public Menu(string[] options)
        {
            Options = options;
            SelectedIndex = 0;
        }


        private void DisplayOptions()
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

            for (int i = 0; i < Options.Length; i++)
            {
                string currentOption = Options[i];

                if (i == SelectedIndex)
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


        public int Run()
        {
            ConsoleKey keyPressed;

            do
            {
                Console.Clear();
                DisplayOptions();

                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                keyPressed = keyInfo.Key;

                // Update SelectedIndex based on arrow keys.
                if (keyPressed == ConsoleKey.UpArrow)
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
    }
}
