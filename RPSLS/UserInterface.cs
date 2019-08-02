using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    static class UserInterface
    {
        public static void DisplayRules()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock!");
            Console.WriteLine("You will start by choosing single player or multiplayer");
            Console.WriteLine("You will then begin the game by choosing your gesture");
            Console.WriteLine("You will play a best-of-5 games series.");
            Console.WriteLine("Here are the rules of the game:");
            Console.WriteLine("  ");
            Console.WriteLine("Scissors cut paper");
            Console.WriteLine("Paper covers rock");
            Console.WriteLine("Rock crushes lizard");
            Console.WriteLine("Lizard poisons spock");
            Console.WriteLine("Spock smashes scissors");
            Console.WriteLine("Scissors decapitates lizard");
            Console.WriteLine("Lizard eats paper");
            Console.WriteLine("Paper disproves Spock");
            Console.WriteLine("Spock vaporizes rock");
            Console.WriteLine("Rock crushes scissors");
            Console.WriteLine("  ");
            Console.WriteLine("Please press ENTER to begin the game");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
