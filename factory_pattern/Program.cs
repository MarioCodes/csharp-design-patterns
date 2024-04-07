using factoryPattern.models.pizzas;
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
            Console.WriteLine($"Ethan ordered a {pizza.Name}, which has {pizza}\n");

            Pizza pizza2 = nyStore.OrderPizza("clam");
            Console.WriteLine($"Ethan ordered a {pizza2.Name}, which has {pizza2}\n");

            Pizza pizza3 = chicagoStore.OrderPizza("cheese");
            Console.WriteLine($"Joel ordered a {pizza3.Name}, which has {pizza3}\n");

            Pizza pizza4 = chicagoStore.OrderPizza("clam");
            Console.WriteLine($"Joel ordered a {pizza4.Name}, which has {pizza4}\n");
        }

    }
}
