using System;

namespace templateMethodPattern.models
{
    public class Coffee : CaffeineBeverage
    {
        protected override void AddCondiments()
        {
            Console.WriteLine("adding sugar and milk");
        }

        protected override void Brew()
        {
            Console.WriteLine("dripping coffee through filter");
        }
    }
}
