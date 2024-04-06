namespace decoratorPattern.beverages.@abstract
{
    // beverage is the base class
    public abstract class Beverage
    {
        public virtual string Description { get; set; } = "Unknown beverage";

        public abstract double Cost();
    }
}
