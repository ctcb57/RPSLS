﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Player
    {
        //member variables
        public string gesture;
        public int winCounter;
        public string name;
        //constructor

        //member methods
        public abstract string ChooseGesture();

        public abstract string ChooseName();
    }
}
