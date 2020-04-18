using Ducks.Library.Interfaces;
using System;

namespace Ducks.Library.Behaviors.Swimming
{
    public class SwimWithWings : ISwimBehavior
    {
        public void Swim()
        {
            Console.WriteLine("I swim with my Wings!");
        }
    }
}
