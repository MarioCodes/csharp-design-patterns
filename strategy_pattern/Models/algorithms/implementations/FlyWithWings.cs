﻿using strategyPattern.Models.algorithms.interfaces;
using System;

namespace strategyPattern.Models.algorithms.implementations
{
    public class FlyWithWings : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("Flying with wings");
        }

    }
}
