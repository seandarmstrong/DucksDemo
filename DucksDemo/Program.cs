using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ducks.Library.Abstract;
using Ducks.Library.Behaviors.Flying;
using Ducks.Library.Behaviors.Sounds;
using Ducks.Library.Ducks;


namespace DucksDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var ducks = new List<Duck>()
            {
                new Mallard(new FlyWithWingsBehavior(), new QuackBehavior()),
                new WoodDuck(new FlyWithWingsBehavior(), new QuackBehavior()),
                new RubberDuck(new NoFlyBehavior(), new NoSoundBehavior()),
                new DecoyDuck(new NoFlyBehavior(), new NoSoundBehavior())
            };

            foreach (var duck in ducks)
            {
                duck.Display();
                duck.PerformFly();
                duck.MakeSound();
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
