using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {   //Things to do for this game:
        //need to give them their name for the sake of the game aesthetic
        //make the computer's name Sheldon
        //Need to make the class of player - player will be an abstract parent
        //create the inheritance of player to computer player
        //create a list that contains all of the options for the game
        //code the logic for what beats what in the game
        //in the computer version of the game have it decide the decision randomly
        //create a winningThreshold of three
        //need to be sure the turn will restart if both the player and the opponent throw the same thing

        //member variables
        Player player1;
        Player player2;
        public int winningThreshold;
        //place your list string here


        //constructor
        public Game()
        { 
            winningThreshold = 3;
        }
        //member methods
        private void DisplayRules()
        {
            Console.WriteLine("Welcome to the arena of Rock, Paper, Scissors, Lizard, Spock! " +
                "You will start by selecting whether you want to play against a human or against " +
                "the computer.  In a best-of-5 series, you will battle until there is a clear " +
                "winner.  You will start by choosing a gesture.  The opponent will follow by selecting " +
                "their gesture.  In the game, the following rules apply: Scissors beat Paper and " +
                "Lizard but loses to Rock and Spock.  Paper beats Rock and Spock but loses to " +
                "Scissors and Lizard.  Rock beats Lizard and Scissors but loses to Spock and Paper. " +
                "Lizard beats Paper and Spock but loses to Scissors and Rock.  Spock beats Scissors " +
                "and Rock but loses to Paper and Lizard.  Press ENTER to continue.");
            Console.ReadLine();
        }

        private int GetNumberOfPlayers()
        {
            Console.WriteLine("Choose whether this is a single player or multiplayer game. " +
                "Press 1 for single player and 2 for multiplayer.");
            int numberOfPlayers = int.Parse(Console.ReadLine());
            return numberOfPlayers;
        }

        private void SettingUpPlayers(int numberOfPlayers)
        {
            if(numberOfPlayers == 1)
            {
                player1 = new HumanPlayer();
                player2 = new ComputerPlayer();
            }
            else
            {
                player1 = new HumanPlayer();
                player2 = new HumanPlayer();
            }
        }


        public void RunGame()
        {
            DisplayRules();

            int numberPlayers = GetNumberOfPlayers();
            SettingUpPlayers(numberPlayers);
            player1.ChooseName();
            player2.ChooseName();

        }

    }
}
