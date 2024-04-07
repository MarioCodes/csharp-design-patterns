using factoryPattern.pizza;
using factoryPattern.service;
using System;

namespace template
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();

            Pizza pizza = nyStore.OrderPizza("cheese");
            Console.WriteLine($"Ethan ordered a {pizza.Name}\n");

            Pizza pizza2 = chicagoStore.OrderPizza("cheese");
            Console.WriteLine($"Joel ordered a {pizza2.Name}\n");
        }

    }
}
