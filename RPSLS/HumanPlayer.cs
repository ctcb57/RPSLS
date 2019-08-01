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
            gesture = Console.ReadLine();
            return gesture;
        }
        public override string ChooseName()
        {
            Console.WriteLine("Choose your name");
            name = Console.ReadLine();
            return name;
        }

    }
}
