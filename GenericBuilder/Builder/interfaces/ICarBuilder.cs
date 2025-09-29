using builderPattern.Models;

namespace builderPattern.Builder.interfaces
{
    public interface ICarBuilder
    {
        public ICarBuilder WithMake(string make);
        public ICarBuilder WithModel(string model);
        public ICarBuilder WithYear(int year);
        public Car Build();
    }
}
