using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFourGame
{
    public class MenuSpanish : Menu
    {

        private Message Output = new MessageSpanish(); //creates a message object.

        private string[] Options;


        public MenuSpanish()
        {
            Options = Output.MenuOptions();  //brings the menu options from the message object           
        }


        public override void DisplayOptions() //public access modifier in the function definition.
        {

            base.DisplayOptions(); //parent has a private access modifier in helper method
        }


        public override void MenuRun()
        {

            base.MenuRun();

        }
    }

}
