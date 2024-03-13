using strategyPattern.Models;
using strategyPattern.Models.algorithms.implementations;

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
        }

    }
}
