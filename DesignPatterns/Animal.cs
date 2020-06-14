using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
   

    class Animal
    {
        public Flys flyType; // this is called composition. When you add functionality through the interface with dynamic changes possible
        public string Name { get; set; }
        public string Height { get; set; }
        public int Speed { get; set; }
        public string Sound { get; set; }
        private double _weight;
        public double Weight
        {
            get
            {
                return this._weight;
            }
            set
            {
                if(value > 0)
                {
                    this._weight = value;
                }
                else
                {
                    Console.WriteLine("enter a positive weight");
                }
            }
        }
        public string TryToFly()
        {
            return flyType.fly();
        }
        public void SetFly(Flys flyingType)
        {
            this.flyType = flyingType;
        }
    }
}
