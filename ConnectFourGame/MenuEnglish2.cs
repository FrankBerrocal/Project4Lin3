using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFourGame
{
    public class MenuEnglish2 : Menu
    {
        

        
        
        private Message output = new MessageEnglish(); //creates a message object.
        
        private string[] Options;
        
        
        public MenuEnglish2()
        {
            Options = output.MenuOptions();  //brings the menu options from the message object           
        }


        public override void DisplayOptions() //public access modifier in the funtion definition.
        {

            base.DisplayOptions(); //parent has a private access modifier in helper method
        }


        public override void MenuRun()
        {

            base.MenuRun();

        }
    }

}
