using System;

namespace StrategyPattern
{
    class AnimalRun
    {
        static void Main(string[] args)
        {
            Animal DogTommy = new Dog();
            Animal BirdSweety = new Bird();
            Console.WriteLine("Dog : " + DogTommy.TryToFly());
            Console.WriteLine("Bird : " + BirdSweety.TryToFly());
            DogTommy.SetFly(new CanFly());
            Console.WriteLine("Dog : " + DogTommy.TryToFly());
        }
    }
}
