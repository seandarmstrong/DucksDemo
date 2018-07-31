using System;
using Ducks.Library.Interfaces;

namespace Ducks.Library.Abstract
{
    public abstract class Duck
    {
        private IFlyBehavior _flyBehavior;

        protected Duck(IFlyBehavior flyBehavior)
        {
            _flyBehavior = flyBehavior;
        }
        public void Quack()
        {
            Console.WriteLine("Quack");
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
