using decoratorPattern.beverages.@abstract;
using decoratorPattern.condiments.@abstract;

namespace decoratorPattern.condiments
{
    public class Soy : CondimentDecorator
    {
        Beverage _beverage;

        public Soy(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string Description { get => $"{_beverage.Description}, Soy"; set => _beverage.Description = $"{_beverage.Description}, Soy"; }

        public override double Cost()
        {
            return _beverage.Cost() + .50;
        }

    }
}
