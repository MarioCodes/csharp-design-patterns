using builderPattern.Builder.interfaces;
using builderPattern.Models;

namespace BasicBuilder.Director.interfaces
{
    public interface ICarDirector
    {
        public Car ConstructSportsCar(ICarBuilder builder);
        public Car ConstructSUV(ICarBuilder builder);
    }
}
