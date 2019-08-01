using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Player
    {
        //member variables
        public int playerNumber;
        public int winCounter;

        //constructor
        public Player(int playerNumber)
        {
            this.playerNumber = playerNumber;
            winCounter = 0;
        }
        //member methods
        public abstract void ChooseGesture();
    }
}
