using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ducks.Library.Abstract;
using Ducks.Library.Ducks;


namespace DucksDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var ducks = new List<Duck>()
            {
                new Mallard(),
                new WoodDuck()
            };

            foreach (var duck in ducks)
            {
                duck.Display();
                duck.Fly();
                duck.Quack();
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
