using strategyPattern.Models.algorithms.interfaces;
using System;

namespace strategyPattern.Models.algorithms.implementations
{
    public class Quack : IQuackBehaviour
    {
        void IQuackBehaviour.Quack()
        {
            Console.WriteLine("quacks like a duck");
        }

    }
}
