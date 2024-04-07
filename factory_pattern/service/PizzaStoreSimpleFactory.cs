using factoryPattern.pizza;
using factoryPattern.simpleFactory;

namespace factoryPattern.service
{
    // this uses simple factory, which is not the same as Factory pattern!
    //  simple factory delegates the object's creation to another class, meanwhile Factory pattern delegates the creation to its subclasses
    public abstract class PizzaStoreSimpleFactory
    {
        private SimplePizzaFactory _factory;

        public PizzaStoreSimpleFactory(SimplePizzaFactory factory)
        {
            _factory = factory;
        }

        public Pizza OrderPizza(string type)
        {
            Pizza pizza = _factory.CreatePizza(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }

    }
}
