using strategyPattern.Models.algorithms.interfaces;
using System;

namespace strategyPattern.Models.algorithms
{
    public class Squeak : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Squeaks like a rubber duck");
        }

    }
}
