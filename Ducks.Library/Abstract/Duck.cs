using System;

namespace Ducks.Library.Abstract
{
    public abstract class Duck
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }

        public void Fly()
        {
            Console.WriteLine("I'm Flying");
        }

        public abstract void Display();
    }
}
