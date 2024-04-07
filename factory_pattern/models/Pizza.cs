using System;
using System.Collections.Generic;

namespace factoryPattern.pizza
{
    // this is marked as abstract so we cannot instantiate Pizza class. We need to operate through subclases
    public abstract class Pizza
    {
        public string Name { get; set; }
        public string Dough {  get; set; }
        public string Sauce { get; set; }
        public List<string> Toppings { get; set; } = new List<string>();

        public void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Adding toppings: ");
            Toppings.ForEach(topping => Console.WriteLine($" {topping}"));
        }

        public void Bake()
        {
            Console.WriteLine("Bake for 25 minutes");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public void Box()
        {
            Console.WriteLine("Place pizza in box");
        }
    }
}
