using System;

namespace templateMethodPattern.models
{
    public class Tea : CaffeineBeverage
    {
        protected override void AddCondiments()
        {
            Console.WriteLine("adding lemon");
        }

        protected override void Brew()
        {
            Console.WriteLine("stepping the tea");
        }
    }
}
