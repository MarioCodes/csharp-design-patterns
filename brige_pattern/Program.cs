using builderPattern.baseclass;
using System;

namespace builder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var director = new Director();

            var builder = new CarBuilder();
            director.ConstructSportsCar(builder);
            Car car = builder.GetProduct();
            Console.WriteLine(car.ToString);

            var manualBuilder = new CarManualBuilder();
            director.ConstructSportsCar(manualBuilder);

            /*
             * The final product is often retrieved from a builder
             * since the director isn't aware of concrete
             * builders and products
             */
            Manual manual = manualBuilder.GetProduct();
        }

    }
}
