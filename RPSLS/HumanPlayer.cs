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
        public int selection;
        //constructor
        public HumanPlayer()
        {


        }
        //member methods
        public override int ChooseGesture()
        {
            int selection;
            Console.WriteLine("Enter the number for your selection: 1 = Paper, 2 = Rock, 3 = Scissors, " +
                "4 = Lizard, 5 = Spock");
            selection = Convert.ToInt32(Console.ReadLine());
            if(selection < 1 || selection > 5)
            {

            }
            return selection;
        }
    }
}
