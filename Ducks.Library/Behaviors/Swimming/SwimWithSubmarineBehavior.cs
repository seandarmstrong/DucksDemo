using Ducks.Library.Interfaces;
using System;

namespace Ducks.Library.Behaviors.Swimming
{
    public class SwimWithSubmarineBehavior : ISwimBehavior
    {
        public void Swim()
        {
            Console.WriteLine("I'm swimming in my brand new submarine!");
        }
    }
}
