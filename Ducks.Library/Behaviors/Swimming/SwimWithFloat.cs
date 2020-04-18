using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ducks.Library.Interfaces;

namespace Ducks.Library.Behaviors.Swimming
{
    public class SwimWithFloat : ISwimBehavior
    {
        public void Swim()
        {
            Console.WriteLine("I'm floating");
        }
    }
}
