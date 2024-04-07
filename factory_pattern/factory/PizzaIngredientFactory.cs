using factoryPattern.models.ingredients;
using System.Collections.Generic;

namespace factoryPattern.factory
{
    public interface PizzaIngredientFactory
    {
        public Dough CreateDough();
        public Sauce CreateSauce();
        public Cheese CreateCheese();
        public List<Veggies> CreateVeggies();
        public Pepperoni CreatePepperoni();
        public Clams CreateClams();
    }
}
