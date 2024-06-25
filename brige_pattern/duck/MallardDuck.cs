﻿using System;

namespace adapterPattern.duck
{
    public class MallardDuck : Duck
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying!");
        }

        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
