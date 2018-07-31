using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ducks.Library.Abstract;

namespace Ducks.Library.Ducks
{
    public class RubberDuck : Duck
    {
        // TODO: I don't quack, I squeak.
        // TODO: I can't fly, unless I get thrown or something.
        // TODO: I guess I can swim... if by swimming you mean floating and not going anywhere under my own power.
        public override void Display()
        {
            Console.WriteLine("I'm small, yello, and made of rubber.");
        }
    }
}
