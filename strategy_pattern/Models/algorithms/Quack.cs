using strategyPattern.Models.algorithms.interfaces;
using System;

namespace strategyPattern.Models.algorithms
{
    public class Quack : IQuackBehaviour
    {
        void IQuackBehaviour.Quack()
        {
            Console.WriteLine("quacks like a duck");
        }

    }
}
