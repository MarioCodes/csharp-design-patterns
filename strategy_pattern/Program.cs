using strategyPattern.Models;
using strategyPattern.Models.algorithms;

namespace crud
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Duck duck = new MallardDuck(new Quack(), new FlyNoWay());
            duck.PerformQuack();
            duck.PerformFly();
            duck.Display();

            Duck duck2 = new RedheadDuck(new Squeak(), new FlyWithWings());
            duck2.PerformQuack();
            duck2.PerformFly();
            duck2.Display();
        }

    }
}
