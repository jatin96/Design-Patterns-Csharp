using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class Bird : Animal
    {
        public Bird() : base()
        {
            flyType = new CanFly();
            this.Sound = "chirp";
        }
    }
}
