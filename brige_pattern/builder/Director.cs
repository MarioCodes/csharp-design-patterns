using builderPattern.interfaces;

namespace builderPattern.builder
{
    /*
     * The final product is often retrieved from a builder
     * since the director isn't aware of concrete
     * builders and products
     */
    public class Director
    {
        public void ConstructSportsCar(Builder builder)
        {
            builder.Reset();
            builder.SetSeats(2);
            builder.SetEngine("v12");
            builder.SetTripComputer(true);
            builder.SetGps(true);
        }

        public void ConstructSUV(Builder builder)
        {
            builder.Reset();
            builder.SetSeats(5);
            builder.SetEngine("v6");
            builder.SetTripComputer(false);
            builder.SetGps(true);
        }
    }
}
