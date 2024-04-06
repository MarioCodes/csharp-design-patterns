using decoratorPattern.beverages.@abstract;
using decoratorPattern.condiments.@abstract;

namespace decoratorPattern.condiments
{
    public class Whip : CondimentDecorator
    {
        Beverage _beverage;

        public Whip(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string Description { get => $"{_beverage.Description}, Whip"; set => _beverage.Description = $"{_beverage.Description}, Whip"; }

        public override double Cost()
        {
            return _beverage.Cost() + .15;
        }

    }
}
