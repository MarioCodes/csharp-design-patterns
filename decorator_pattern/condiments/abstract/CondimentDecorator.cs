using decoratorPattern.beverages.@abstract;

namespace decoratorPattern.condiments.@abstract
{
    // condiment is also a beverage! we may have multiple condiments for any beverage
    public abstract class CondimentDecorator : Beverage
    {
        // we need all children to implement and override with a description
        public abstract override string Description { get; set; }
    }
}
