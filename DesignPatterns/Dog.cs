using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class Dog : Animal
    {
        public Dog() : base()
        {
            this.Sound = "bark"; 
            flyType = new CannotFly();

        }
    }
}
