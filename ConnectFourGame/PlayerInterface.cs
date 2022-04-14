using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFourGame
{
    public interface PlayerInterface
    {

        Message getPlayerColor();
        void DisplayPlayerColorBlue();
        void DisplayPlayerColorYellow();
        void DisplayPlayerColorDarkYellow();
        void DisplayPlayerColorWhite();
        void DisplayPlayerColorRed();
    }
}
