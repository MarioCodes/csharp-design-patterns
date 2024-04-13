
using System;
using templateMethodPattern.models;

namespace adapter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CaffeineBeverage coffee = new Coffee();
            CaffeineBeverage tea = new Tea();

            coffee.PrepareRecipe();
            Console.WriteLine();
            tea.PrepareRecipe();
        }

    }
}
