using strategyPattern.Models.algorithms.implementations;
using strategyPattern.Models.algorithms.interfaces;
using System;

namespace strategyPattern.Models
{
    public class MallardDuck : Duck
    {
        public MallardDuck(IQuackBehaviour quack,
            IFlyBehaviour fly)
        {
            quackBehaviour = quack;
            flyBehaviour = fly;
        }

        public override void Display()
        {
            Console.WriteLine("Looks like a Mallard Duck");
        }
    }
}
