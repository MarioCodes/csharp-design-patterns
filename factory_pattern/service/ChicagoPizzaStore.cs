using factoryPattern.factory;
using factoryPattern.models.pizzas;

namespace factoryPattern.service
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string item)
        {
            ChicagoPizzaIngredientFactory factory = new ChicagoPizzaIngredientFactory();
            Pizza pizza = null;
            switch (item)
            {
                case "cheese":
                    pizza = new CheesePizza(factory);
                    pizza.Name = "Chicago style cheese pizza";
                    break;
                case "pepperoni":
                    pizza = new PepperoniPizza(factory);
                    pizza.Name = "Chicago style pepperoni pizza";
                    break;
                case "clam":
                    pizza = new ClamPizza(factory);
                    pizza.Name = "Chicago style clam pizza";
                    break;
                case "veggie":
                    pizza = new VeggiePizza(factory);
                    pizza.Name = "Chicago stye veggie pizza";
                    break;
                default:
                    break;
            }
            return pizza;
        }
    }
}
