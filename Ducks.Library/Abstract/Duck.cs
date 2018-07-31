using System;
using Ducks.Library.Interfaces;

namespace Ducks.Library.Abstract
{
    public abstract class Duck : ICanFly
    {
        private IFlyBehavior _flyBehavior;
        private ISoundBehavior _soundBehavior;

        protected Duck(IFlyBehavior flyBehavior, ISoundBehavior soundBehavior)
        {
            _flyBehavior = flyBehavior;
            _soundBehavior = soundBehavior;
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
            Console.WriteLine("I'm Swimming!");
        }

        public abstract void Display();
    }
}
