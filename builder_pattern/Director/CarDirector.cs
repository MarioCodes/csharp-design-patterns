using BasicBuilder.Director.interfaces;
using builderPattern.Builder.interfaces;
using builderPattern.Models;

namespace BasicBuilder.Director
{
    public class CarDirector : ICarDirector
    {
        public Car ConstructSportsCar(ICarBuilder builder)
        {
            builder.WithMake("Porsche")
                   .WithModel("911")
                   .WithYear(2024);
            return builder.Build();
        }

        public Car ConstructSUV(ICarBuilder builder)
        {
            builder.WithMake("Toyota")
                   .WithModel("Highlander")
                   .WithYear(2024);
            return builder.Build();
        }
    }
}
