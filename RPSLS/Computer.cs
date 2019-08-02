using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Computer : Player
    {
        //member variables
        Random random;
        List<string> gestures;

        //contractor
        public Computer()
        {
            random = new Random();
            gestures = new List<string>() { "rock", "paper", "scissors", "lizard", "spock" };
        }

        //member methods
        public override string ChooseGesture()
        {
            int index = random.Next(gestures.Count);
            Console.WriteLine(gestures[index]);
            gesture = gestures[index];
            return gesture;
        }
        public override string ChooseName()
        {
            Console.WriteLine("Choose your opponent's name");
            name = Console.ReadLine().Trim();
            Console.Clear();
            return name;
            
        }


    }
}
