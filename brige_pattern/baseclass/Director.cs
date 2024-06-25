namespace builderPattern.baseclass
{
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
