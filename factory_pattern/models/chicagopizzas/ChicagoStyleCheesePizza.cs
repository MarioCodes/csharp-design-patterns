using System;

namespace factoryPattern.pizza
{
    public class ChicagoStyleCheesePizza : Pizza
    {
        public ChicagoStyleCheesePizza()
        {
            Name = "Chicago style deep dish cheese pizza";
            Dough = "Extra thick crust dough";
            Sauce = "Plum tomato Sauce";

            Toppings.Add("Shredded mozzarella cheese");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}
