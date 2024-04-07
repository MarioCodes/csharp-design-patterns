using factoryPattern.factory;
using factoryPattern.models;
using factoryPattern.models.pizzas;

namespace factoryPattern.service
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string item)
        {
            Pizza pizza = null;
            PizzaIngredientFactory factory = new NYPizzaIngredientFactory();

            switch (item)
            {
                case "cheese":
                    pizza = new CheesePizza(factory);
                    pizza.Name = "New york style cheese pizza";
                    break;
                case "pepperoni":
                    pizza = new PepperoniPizza(factory);
                    pizza.Name = "New york style pepperoni pizza";
                    break;
                case "clam":
                    pizza = new ClamPizza(factory);
                    pizza.Name = "New york style clam pizza";
                    break;
                case "veggie":
                    pizza = new VeggiePizza(factory);
                    pizza.Name = "New york stye veggie pizza";
                    break;
                default:
                    break;
            }
            return pizza;
        }
    }
}
