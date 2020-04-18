﻿using System;
using Ducks.Library.Abstract;
using Ducks.Library.Interfaces;

namespace Ducks.Library.Ducks
{
    public class WoodDuck : Duck
    {
        public WoodDuck(IFlyBehavior flyBehavior, ISoundBehavior soundBehavior, ISwimBehavior swimBehavior) : base(flyBehavior, soundBehavior, swimBehavior)
        {
        }
        public override void Display()
        {
            //Again, taken from Wikipedia
            Console.WriteLine("The adult male has distinctive multicolored iridescent plumage and red eyes,with a distinctive white flare down the neck.");
        }

        
    }
}