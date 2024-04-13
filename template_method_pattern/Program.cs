
using System;
using templateMethodPattern.models;

namespace templateMethod
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // basic version
            CaffeineBeverage coffee = new Coffee();
            CaffeineBeverage tea = new Tea();

            coffee.PrepareRecipe();
            Console.WriteLine();
            tea.PrepareRecipe();
            Console.WriteLine();

            // hook version
            CaffeineBeverageWithHook coffeeHook = new CoffeeWithHook();
            CaffeineBeverageWithHook teaHook = new TeaWithHook();

            coffeeHook.PrepareRecipe();
            Console.WriteLine();
            teaHook.PrepareRecipe();
        }

    }
}
