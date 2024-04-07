using factoryPattern.models.ingredients;
using factoryPattern.models.ingredients.nyingredients;
using System.Collections.Generic;

namespace factoryPattern.factory
{
    public class ChicagoPizzaIngredientFactory : PizzaIngredientFactory
    {
        public Cheese CreateCheese()
        {
            return new EmmentalCheese();
        }

        public Clams CreateClams()
        {
            return new FrozenClams();
        }

        public Dough CreateDough()
        {
            return new ThickCrustDough();
        }

        public Pepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public Sauce CreateSauce()
        {
            return new BarbaqueSauce();
        }

        public List<Veggies> CreateVeggies()
        {
            return new List<Veggies> { new Garlic(), new Onion(), new Mushroom(), new RedPepper() };
        }
    }
}
