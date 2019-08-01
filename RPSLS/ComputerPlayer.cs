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

        //contractor

        //member methods
        public override void ChooseGesture()
        {

        }
        public override void ChooseName()
        {
            Console.WriteLine("Choose your opponent: Sheldon or Leonard");
            name = Console.ReadLine();
        }


    }
}
