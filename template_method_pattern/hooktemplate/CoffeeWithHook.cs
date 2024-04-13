using System;

namespace templateMethodPattern.models
{
    // we override the hook as we don't want no condiments
    public class CoffeeWithHook : CaffeineBeverageWithHook
    {
        protected override bool CustomerWantsCondiments()
        {
            return false;
        }

        protected override void AddCondiments()
        {
            // this won't be called
            Console.WriteLine("adding sugar and milk");
        }

        protected override void Brew()
        {
            Console.WriteLine("dripping coffee through filter");
        }
    }
}
