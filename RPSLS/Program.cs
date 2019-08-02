using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace RPSLS
{
    class Program
    {
        static void Main(string[] args)
        {
            WindowsMediaPlayer myplayer = new WindowsMediaPlayer();
            myplayer.URL = "The-Big-Bang-Theory-Theme-Song.mp3";
            myplayer.controls.play();
            Game game = new Game();
            game.RunGame();

        }
    }
}
