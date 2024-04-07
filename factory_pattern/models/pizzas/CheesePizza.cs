using factoryPattern.factory;
using System;

namespace factoryPattern.models.pizzas
{
    public class CheesePizza : Pizza
    {
        PizzaIngredientFactory _ingredientFactory;

        public CheesePizza(PizzaIngredientFactory ingredientFactory)
        {
            _ingredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            Dough = _ingredientFactory.CreateDough();
            Sauce = _ingredientFactory.CreateSauce();
            Cheese = _ingredientFactory.CreateCheese();
        }

        public override string ToString()
        {
            return $"dough {Dough}, sauce {Sauce}, cheese {Cheese}";
        }
    }
}
