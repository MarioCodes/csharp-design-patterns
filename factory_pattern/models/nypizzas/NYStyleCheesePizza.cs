namespace factoryPattern.pizza
{
    public class NYStyleCheesePizza : Pizza
    {
        public NYStyleCheesePizza()
        {
            Name = "NY style sauce and cheese pizza";
            Dough = "Thin crust dough";
            Sauce = "Marinara Sauce";

            Toppings.Add("Grated reggiano cheese");
        }
    }
}
