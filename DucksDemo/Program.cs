using Ducks.Library.Abstract;
using Ducks.Library.Behaviors.Flying;
using Ducks.Library.Behaviors.Sounds;
using Ducks.Library.Behaviors.Swimming;
using Ducks.Library.Ducks;
using System;
using System.Collections.Generic;


namespace DucksDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var ducks = new List<Duck>()
            {
                new Mallard(new FlyWithWingsBehavior(), new QuackBehavior(), new SwimWithWings()),
                new WoodDuck(new FlyWithWingsBehavior(), new QuackBehavior(), new SwimWithWings()),
                new RubberDuck(new FlyWithThrowingBehavior(), new SqueakBehavior(), new SwimWithFloat()),
                new DecoyDuck(new NoFlyBehavior(), new NoSoundBehavior(), new SwimWithSubmarineBehavior())
            };

            foreach (var duck in ducks)
            {
                duck.Display();
                duck.PerformFly();
                duck.MakeSound();
                duck.Swim();
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
