using decoratorPattern.beverages.@abstract;

namespace decoratorPattern.beverages
{
    // this are the objects we're going to, dynamically, add new behaviour
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
