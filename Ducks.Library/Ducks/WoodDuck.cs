using System;
using Ducks.Library.Abstract;

namespace Ducks.Library.Ducks
{
    public class WoodDuck : Duck
    {
        public override void Display()
        {
            //Again, taken from Wikipedia
            Console.WriteLine("The adult male has distinctive multicolored iridescent plumage and red eyes,with a distinctive white flare down the neck.");
        }
    }
}