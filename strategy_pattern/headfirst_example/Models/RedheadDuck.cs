using strategyPattern.Models.algorithms.interfaces;
using System;

namespace strategyPattern.Models
{
    public class RedheadDuck : Duck
    {
        public RedheadDuck(
            IQuackBehaviour quack,
            IFlyBehaviour fly)
        {
            quackBehaviour = quack;
            flyBehaviour = fly;
        }

        public override void Display()
        {
            Console.WriteLine("Looks like a Redhead Duck");
        }
    }
}
