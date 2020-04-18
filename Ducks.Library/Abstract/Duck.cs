using System;
using Ducks.Library.Interfaces;

namespace Ducks.Library.Abstract
{
    public abstract class Duck : ICanFly
    {
        private IFlyBehavior _flyBehavior;
        private ISoundBehavior _soundBehavior;
        private ISwimBehavior _swimBehavior;

        protected Duck(IFlyBehavior flyBehavior, ISoundBehavior soundBehavior, ISwimBehavior swimBehavior)
        {
            _flyBehavior = flyBehavior;
            _soundBehavior = soundBehavior;
            _swimBehavior = swimBehavior;
        }
        public void MakeSound()
        {
            _soundBehavior.MakeSound();
        }

        public void PerformFly()
        {
            _flyBehavior.Fly();
        }

        public void SetFlyBehavior(IFlyBehavior flyBehavior)
        {
            _flyBehavior = flyBehavior;
        }

        public void Swim()
        {
            _swimBehavior.Swim(); 
        }

        public abstract void Display();
    }
}
