using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {   //Things to do for this game:
        //write the function to display the rules of the game
        //Need to make the class of player - player will be an abstract parent
        //create the inheritance of player to computer player
        //create a list that contains all of the options for the game
        //code the logic for what beats what in the game
        //in the computer version of the game have it decide the decision randomly
        //create a winningThreshold of three
        //need to be sure the turn will restart if both the player and the opponent throw the same thing

        //member variables
        public string player1;
        public string player2;
        public string computerPlayer;
        public int winningThreshold;

        //contractor

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
                "and Rock but loses to Paper and Lizard.");
            Console.ReadLine();
        }

        public void ChooseGameType()
        {
            int chooseGame;
            Console.WriteLine("Choose whether you would like to play against another human " +
                "or against a computer.  Enter 1 for human, 2 for computer.");
            chooseGame = Convert.ToInt32(Console.ReadLine());

            if(chooseGame == 1)
            {
                PlayAgainstHuman();
            }
            else if(chooseGame == 2)
            {
                PlayAgainstComputer();
            }
            else
            {
                ChooseGameType();
            }
        }

        public void PlayAgainstHuman()
        {

        }

        public void PlayAgainstComputer()
        {

        }


        public void RunGame()
        {
            DisplayRules();

            ChooseGameType();




        }

    }
}
