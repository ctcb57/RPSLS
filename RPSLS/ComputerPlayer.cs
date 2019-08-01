using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class ComputerPlayer : Player
    {
        //member variables
        public Random selectionOptions;

        //contractor
        public ComputerPlayer(int playerType, int winCounter)
        {
            this.playerType = playerType;
            this.winCounter = winCounter;
        }
        //member methods
        public override void ChooseGesture()
        {
            int gesture = selectionOptions.Next(0, 5);


        }

    }
}
