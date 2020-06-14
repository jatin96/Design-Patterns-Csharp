using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    interface Flys
    {
        public string fly();
    }
    class CanFly : Flys
    {
        public string fly()
        {
            return "I can fly";
        }
    }
    class CannotFly : Flys
    {
        public string fly()
        {
            return "I cannot fly";
        }
    }
}
