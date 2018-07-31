using System;
using Ducks.Library.Abstract;

namespace Ducks.Library.Ducks
{
    public class Mallard : Duck
    {
        public override void Display()
        {
            //taken from Wikipedia
            Console.WriteLine("I have a glossy bottle-green head and a white collar that demarcates the head from the purple-tinged brown breast, grey-brown wings, and a pale grey belly. ");
        }
    }
}
