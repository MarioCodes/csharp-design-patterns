using factoryPattern.models.ingredients;
using factoryPattern.models.ingredients.nyingredients;
using System.Collections.Generic;

namespace factoryPattern.factory
{
    public class NYPizzaIngredientFactory : PizzaIngredientFactory
    {
        public Cheese CreateCheese()
        {
            return new ReggianoCheese();
        }

        public Clams CreateClams()
        {
            return new FreshClams();
        }

        public Dough CreateDough()
        {
            return new ThinCrustDough();
        }

        public Pepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public Sauce CreateSauce()
        {
            return new MarinaraSauce();
        }

        public List<Veggies> CreateVeggies()
        {
            return new List<Veggies> { new Garlic(), new Onion(), new Mushroom(), new RedPepper() };
        }
    }
}
