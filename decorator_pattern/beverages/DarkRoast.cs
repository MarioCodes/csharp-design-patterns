using decoratorPattern.beverages.@abstract;

namespace decoratorPattern.beverages
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            Description = "Dark roast";
        }

        public override double Cost()
        {
            return 1.25;
        }
    }
}
