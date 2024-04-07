using factoryPattern.pizza;

namespace factoryPattern.simpleFactory
{
    /*
     * Simple Factory isn't actually a design pattern, but it's commonly used. 
     */
    public class SimplePizzaFactory
    {

        public Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            switch(type)
            {
                case "cheese":
                    pizza = new CheesePizza();
                    break;
                case "pepperoni":
                    pizza = new PepperoniPizza();
                    break;
                case "clam":
                    pizza = new ClamPizza();
                    break;
                case "veggie":
                    pizza = new VeggiePizza();
                    break;
                default:
                    break;
            }
            return pizza;
        }
    }
}
