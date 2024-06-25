﻿using System;

namespace adapterPattern.turkey
{
    public class WildTurkey : Turkey
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying a short distance");
        }

        public void Gobble()
        {
            Console.WriteLine("Gobble gobble");
        }
    }
}
