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
        

        public int Run()
        {
            ConsoleKey keyPressed;

            do
            {
                Console.Clear();
                //DisplayOptions();

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
