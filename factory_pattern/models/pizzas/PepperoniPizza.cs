using factoryPattern.factory;
using System;

namespace factoryPattern.models.pizzas
{
    public class PepperoniPizza : Pizza
    {
        PizzaIngredientFactory _ingredientFactory;

        public PepperoniPizza(PizzaIngredientFactory ingredientFactory)
        {
            _ingredientFactory = ingredientFactory;
        }
        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            Dough = _ingredientFactory.CreateDough();
            Sauce = _ingredientFactory.CreateSauce();
            Cheese = _ingredientFactory.CreateCheese();
            Pepperoni = _ingredientFactory.CreatePepperoni();
        }
        public override string ToString()
        {
            return $"dough {Dough}, sauce {Sauce}, cheese {Cheese}, pepperoni {Pepperoni}";
        }
    }
}
