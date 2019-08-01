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
        public override string ChooseGesture()
        {
            Random random = new Random();
            List<string> gestures = new List<string>() { "rock", "paper", "scissors", "lizard", "spock" };
            int index = random.Next(gestures.Count);
            Console.WriteLine(gestures[index]);
            return gestures[index];
        }
        public override string ChooseName()
        {
            Console.WriteLine("Choose your opponent: Sheldon or Leonard");
            name = Console.ReadLine();
            return name;
        }


    }
}
