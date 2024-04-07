using factoryPattern.pizza;

namespace factoryPattern.service
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            switch (type)
            {
                case "cheese":
                    pizza = new ChicagoStyleCheesePizza();
                    break;
                case "pepperoni":
                    pizza = new ChicagoStylePepperoniPizza();
                    break;
                case "clam":
                    pizza = new ChicagoStyleClamPizza();
                    break;
                case "veggie":
                    pizza = new ChicagoStyleVeggiePizza();
                    break;
                default:
                    break;
            }
            return pizza;
        }
    }
}
