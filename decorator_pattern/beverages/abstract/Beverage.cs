namespace decoratorPattern.beverages.@abstract
{
    public abstract class Beverage
    {
        public virtual string Description { get; set; } = "Unknown beverage";

        public abstract double Cost();
    }
}
