using System;

namespace templateMethodPattern.models
{
    // this class doesn't override the hook as we want the condiments
    public class TeaWithHook : CaffeineBeverageWithHook
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
