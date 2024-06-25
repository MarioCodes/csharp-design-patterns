using adapterPattern.adapter;
using adapterPattern.duck;
using adapterPattern.turkey;
using System;

namespace builder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Duck duck = new MallardDuck();
            Turkey turkey = new WildTurkey();

            Duck turkeyAdapter = new TurkeyAdapter(turkey);

            Console.WriteLine("the turkey says...");
            turkey.Gobble();
            turkey.Fly();

            Console.WriteLine("\nthe duck says...");
            duck.Quack();
            duck.Fly();

            Console.WriteLine("\nthe turkeyadapter says...");
            turkeyAdapter.Quack();
            turkeyAdapter.Fly();
        }

    }
}
