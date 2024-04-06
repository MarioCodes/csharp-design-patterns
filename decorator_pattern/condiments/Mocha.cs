using decoratorPattern.beverages.@abstract;
using decoratorPattern.condiments.@abstract;

namespace decoratorPattern.condiments
{
    public class Mocha : CondimentDecorator
    {
        Beverage _beverage;

        public Mocha(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string Description { get => $"{_beverage.Description}, Mocha"; set => _beverage.Description = $"{_beverage.Description}, Mocha"; }

        public override double Cost()
        {
            return _beverage.Cost() + .20;
        }

    }
}
