using strategyPattern.Models.algorithms.interfaces;
using System;

namespace strategyPattern.Models.algorithms
{
    public class MuteQuack : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("<<Silence>>");
        }

    }
}
