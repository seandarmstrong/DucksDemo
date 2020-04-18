using System;
using Ducks.Library.Abstract;
using Ducks.Library.Interfaces;

namespace Ducks.Library.Ducks
{
    public class Mallard : Duck
    {
        public Mallard(IFlyBehavior flyBehavior, ISoundBehavior soundBehavior, ISwimBehavior swimBehavior) : base(flyBehavior, soundBehavior, swimBehavior)
        {
        }
        public override void Display()
        {
            //taken from Wikipedia
            Console.WriteLine("I have a glossy bottle-green head and a white collar that demarcates the head from the purple-tinged brown breast, grey-brown wings, and a pale grey belly. ");
        }

        
    }
}
