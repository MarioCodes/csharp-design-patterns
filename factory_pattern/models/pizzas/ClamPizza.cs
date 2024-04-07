using factoryPattern.factory;
using System;

namespace factoryPattern.models.pizzas
{
    public class ClamPizza : Pizza
    {
        PizzaIngredientFactory _ingredientFactory;

        public ClamPizza(PizzaIngredientFactory ingredientFactory)
        {
            _ingredientFactory = ingredientFactory;
        }
        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            Dough = _ingredientFactory.CreateDough();
            Sauce = _ingredientFactory.CreateSauce();
            Cheese = _ingredientFactory.CreateCheese();
            Clams = _ingredientFactory.CreateClams();
        }
        public override string ToString()
        {
            return $"dough {Dough}, sauce {Sauce}, cheese {Cheese}, clam {Clams}";
        }
    }
}
