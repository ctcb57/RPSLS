using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {   
        //member variables
        private Player player1;
        private Player player2;
        public int winningThreshold;

        //constructor
        public Game()
        { 
            winningThreshold = 3;
        }
        //member methods

        private int GetNumberOfPlayers()
        {
            Console.WriteLine("Press 1 for single player or 2 for multiplayer");
            int response;

            while(!int.TryParse(Console.ReadLine(), out response) || response < 1 || response > 2)
            {
                Console.WriteLine("You entered an invalid response");
                Console.WriteLine("Press 1 for single player or 2 for multiplayer");
            }
            Console.Clear();
            return response;  
        }

        private void SettingUpPlayers(int numberOfPlayers)
        {
            if(numberOfPlayers == 1)
            {
                player1 = new Human();
                player2 = new Computer();
            }
            else
            {
                player1 = new Human();
                player2 = new Human();
            }
            player1.ChooseName();
            player2.ChooseName();
        }

        private void AskToRestartGame()
        {
            Console.WriteLine("Would you like to play again? Type yes or no. Any response other than yes will end the game.");
            string response = Console.ReadLine();
            string validResponse = response.ToLower().Trim();
            if(validResponse == "yes")
            {
                Console.Clear();
                RunGame();
            }
            else
            {
                Console.WriteLine("Thanks for playing! Press ENTER to exit.");
                Console.ReadLine();
            }
        }


        public void RunGame()
        {
            UserInterface.DisplayRules();

            int numberPlayers = GetNumberOfPlayers();
            SettingUpPlayers(numberPlayers);


            while(player1.winCounter < 3 && player2.winCounter < 3)
            {
                player1.ChooseGesture();
                player2.ChooseGesture();
                Console.WriteLine(player1.name + " chooses " + player1.gesture + " and " + player2.name + " chooses " + player2.gesture);
                if (player1.gesture == "scissors" && player2.gesture == "paper")
                {
                    Console.WriteLine("Scissors cuts paper. " + player1.name + " wins this round.");
                    player1.winCounter++;
                    Console.WriteLine("The score is " + player1.winCounter + " to " + player2.winCounter + ".");
                    Console.WriteLine("Press enter to begin the next round.");
                    Console.ReadLine();
                }
                else if (player1.gesture == "scissors" && player2.gesture == "lizard")
                {
                    Console.WriteLine("Scissors decapitates lizard. " + player1.name + " wins this round.");
                    player1.winCounter++;
                    Console.WriteLine("The score is " + player1.winCounter + " to " + player2.winCounter + ".");
                    Console.WriteLine("Press enter to begin the next round.");
                    Console.ReadLine();
                }
                else if (player1.gesture == "paper" && player2.gesture == "rock")
                {
                    Console.WriteLine("Paper covers rock. " + player1.name + " wins this round.");
                    player1.winCounter++;
                    Console.WriteLine("The score is " + player1.winCounter + " to " + player2.winCounter + ".");
                    Console.WriteLine("Press enter to begin the next round.");
                    Console.ReadLine();
                }
                else if(player1.gesture == "paper" && player2.gesture == "spock")
                {
                    Console.WriteLine("Paper disproves Spock. " + player1.name + " wins this round.");
                    player1.winCounter++;
                    Console.WriteLine("The score is " + player1.winCounter + " to " + player2.winCounter + ".");
                    Console.WriteLine("Press enter to begin the next round.");
                    Console.ReadLine();
                }
                else if(player1.gesture == "rock" && player2.gesture == "lizard")
                {
                    Console.WriteLine("Rock crushes lizard. " + player1.name + " wins this round.");
                    player1.winCounter++;
                    Console.WriteLine("The score is " + player1.winCounter + " to " + player2.winCounter + ".");
                    Console.WriteLine("Press enter to begin the next round.");
                    Console.ReadLine();
                }
                else if(player1.gesture == "rock" && player2.gesture == "scissors")
                {
                    Console.WriteLine("Rock crushes scissors. " + player1.name + " wins this round.");
                    player1.winCounter++;
                    Console.WriteLine("The score is " + player1.winCounter + " to " + player2.winCounter + ".");
                    Console.WriteLine("Press enter to begin the next round.");
                    Console.ReadLine();
                }
                else if (player1.gesture == "lizard" && player2.gesture == "spock")
                {
                    Console.WriteLine("Lizard poisons Spock. " + player1.name + " wins this round.");
                    player1.winCounter++;
                    Console.WriteLine("The score is " + player1.winCounter + " to " + player2.winCounter + ".");
                    Console.WriteLine("Press enter to begin the next round.");
                    Console.ReadLine();
                }
                else if (player1.gesture == "lizard" && player2.gesture == "paper")
                {
                    Console.WriteLine("Lizard eats paper. " + player1.name + " wins this round.");
                    player1.winCounter++;
                    Console.WriteLine("The score is " + player1.winCounter + " to " + player2.winCounter + ".");
                    Console.WriteLine("Press enter to begin the next round.");
                    Console.ReadLine();
                }
                else if (player1.gesture == "spock" && player2.gesture == "scissors")
                {
                    Console.WriteLine("Spock smashes scissors. " + player1.name + " wins this round.");
                    player1.winCounter++;
                    Console.WriteLine("The score is " + player1.winCounter + " to " + player2.winCounter + ".");
                    Console.WriteLine("Press enter to begin the next round.");
                    Console.ReadLine();
                }
                else if (player1.gesture == "spock" && player2.gesture == "rock")
                {
                    Console.WriteLine("Spock vaporizes rock. " + player1.name + " wins this round.");
                    player1.winCounter++;
                    Console.WriteLine("The score is " + player1.winCounter + " to " + player2.winCounter + ".");
                    Console.WriteLine("Press enter to begin the next round.");
                    Console.ReadLine();
                }
                else if(player1.gesture == player2.gesture)
                {
                    Console.WriteLine(player1.name + " and " + player2.name + " chose the same gesture. This round is a tie.");
                    Console.WriteLine("The score is " + player1.winCounter + " to " + player2.winCounter + ".");
                    Console.WriteLine("Press enter to begin the next round.");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine(player2.gesture + " beats " + player1.gesture + ". " + player2.name + " wins this round");
                    player2.winCounter++;
                    Console.WriteLine("The score is " + player1.winCounter + " to " + player2.winCounter + ".");
                    Console.WriteLine("Press enter to begin the next round.");
                    Console.ReadLine();
                }
                Console.Clear();

            }
            if(player1.winCounter > player2.winCounter)
            {
                Console.WriteLine(player1.name + " wins the game! Press enter to continue.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(player2.name + " wins the game! Press enter to continue.");
                Console.ReadLine();
            }
            Console.Clear();
            AskToRestartGame();
        }
    }
}
