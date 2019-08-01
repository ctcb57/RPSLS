using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class HumanPlayer : Player
    {
        //member variables

        //constructor

        //member methods
        public override string ChooseGesture()
        {
            Console.WriteLine("Choose a gesture: rock, paper, scissors, lizard, or spock");
            string response = Console.ReadLine();
            gesture = response.Trim().ToLower();
            if(gesture == "rock" || gesture == "paper" || gesture == "scissors" || gesture == "lizard" || gesture == "spock")
            {
                return gesture;
            }
            else if(gesture == "flamingo")
            {
                Console.WriteLine("Nice try Nevin");
                ChooseGesture();
                return gesture;
            }
            else
            {
                Console.WriteLine("Invalid selection.");
                ChooseGesture();
                return gesture;
            }

        }
        public override string ChooseName()
        {
            Console.WriteLine("Choose your name");
            name = Console.ReadLine();
            return name.Trim();
        }

    }
}
