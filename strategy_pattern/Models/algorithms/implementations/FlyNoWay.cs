using strategyPattern.Models.algorithms.interfaces;
using System;

namespace strategyPattern.Models.algorithms.implementations
{
    public class FlyNoWay : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("this duck cannot fly");
        }

    }
}
