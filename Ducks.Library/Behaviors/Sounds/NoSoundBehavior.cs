using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ducks.Library.Interfaces;

namespace Ducks.Library.Behaviors.Sounds
{
    public class NoSoundBehavior : ISoundBehavior
    {
        public void MakeSound()
        {
            throw new NotImplementedException();
        }
    }
}
