using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ducks.Library.Abstract;

namespace Ducks.Library.Ducks
{
    public class DecoyDuck : Duck
    {
        //TODO: Yeah, I can't swim either.  Only float.
        //TODO: I don't quack either.  In fact, I'm completely silent......
        public override void Display()
        {
            Console.WriteLine("I look like a normal duck, but I'm made of wood.");
        }
    }
}
