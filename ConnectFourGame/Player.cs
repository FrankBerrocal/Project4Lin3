using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFourGame
{
    public class Player : PlayerInterface
    {
        private string PlayerName { get; set; }
        private Message PlayerColor { get; set; }

        public Player()
        {}

        public Player(string playerName)
        {
            PlayerName = playerName;
        }

        public Player(string playerName, Message output)
        {
            PlayerName = playerName;
            PlayerColor = output;
        }

        public override string ToString()
        {
            return PlayerName;
        }

        public Message getPlayerColor()
        {
            return PlayerColor;
        }

        public void DisplayPlayerColorBlue()
        {

            this.PlayerColor.ForegroundBlue();
        }

        public void DisplayPlayerColorYellow()
        {

            this.PlayerColor.ForegroundYellow();
        }

        public void DisplayPlayerColorDarkYellow()
        {

            this.PlayerColor.ForegroundDarkYellow();
        }

        public void DisplayPlayerColorWhite()
        {

            this.PlayerColor.ForegroundWhite();
        }

        public void DisplayPlayerColorRed()
        {

            this.PlayerColor.ForegroundRed();
        }
    }

}

