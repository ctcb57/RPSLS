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
            string player1Name = player1.ChooseName();
            string player2Name = player2.ChooseName();
            while(player1.winCounter < 3 && player2.winCounter < 3)
            {
                string player1Choice = player1.ChooseGesture();
                string player2Choice = player2.ChooseGesture();
                Console.WriteLine(player1Name + " chooses " + player1Choice + " and " + player2Name + " chooses " + player2Choice);
                if (player1Choice == "scissors" && player2Choice == "paper")
                {
                    Console.WriteLine("Scissors cuts paper. " + player1Name + " wins this round.");
                    player1.winCounter++;
                    Console.ReadLine();
                }
                else if (player1Choice == "scissors" && player2Choice == "lizard")
                {
                    Console.WriteLine("Scissors decapitates lizard. " + player1Name + " wins this round.");
                    player1.winCounter++;
                    Console.ReadLine();
                }
                else if (player1Choice == "paper" && player2Choice == "rock")
                {
                    Console.WriteLine("Paper covers rock. " + player1Name + " wins this round.");
                    player1.winCounter++;
                    Console.ReadLine();
                }
                else if(player1Choice == "paper" && player2Choice == "spock")
                {
                    Console.WriteLine("Paper disproves Spock. " + player1Name + " wins this round.");
                    player1.winCounter++;
                    Console.ReadLine();
                }
                else if(player1Choice == "rock" && player2Choice == "lizard")
                {
                    Console.WriteLine("Rock crushes lizard. " + player1Name + " wins this round.");
                    player1.winCounter++;
                    Console.ReadLine();
                }
                else if(player1Choice == "rock" && player2Choice == "scissors")
                {
                    Console.WriteLine("Rock crushes scissors. " + player1Name + " wins this round.");
                    player1.winCounter++;
                    Console.ReadLine();
                }
                else if (player1Choice == "lizard" && player2Choice == "spock")
                {
                    Console.WriteLine("Lizard poisons Spock. " + player1Name + " wins this round.");
                    player1.winCounter++;
                    Console.ReadLine();
                }
                else if (player1Choice == "lizard" && player2Choice == "paper")
                {
                    Console.WriteLine("Lizard eats paper. " + player1Name + " wins this round.");
                    player1.winCounter++;
                    Console.ReadLine();
                }
                else if (player1Choice == "spock" && player2Choice == "scissors")
                {
                    Console.WriteLine("Spock smashes scissors. " + player1Name + " wins this round.");
                    player1.winCounter++;
                    Console.ReadLine();
                }
                else if (player1Choice == "spock" && player2Choice == "rock")
                {
                    Console.WriteLine("Spock vaporizes rock. " + player1Name + " wins this round.");
                    player1.winCounter++;
                    Console.ReadLine();
                }
                else if(player1Choice == player2Choice)
                {
                    Console.WriteLine(player1Name + " and " + player2Name + " choose the same. This round is a tie.");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine(player2Choice + " beats " + player1Choice + ". " + player2Name + "wins this round");
                    player2.winCounter++;
                    Console.ReadLine();
                }

            }
            if(player1.winCounter > player2.winCounter)
            {
                Console.WriteLine(player1Name + " wins the game!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(player2Name + " wins the game!");
                Console.ReadLine();
            }
        }

    }
}
