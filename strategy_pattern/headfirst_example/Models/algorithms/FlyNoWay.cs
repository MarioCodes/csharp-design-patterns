using strategyPattern.Models.algorithms.interfaces;
using System;

namespace strategyPattern.Models.algorithms
{
    public class FlyNoWay : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("this duck cannot fly");
        }

    }
}
