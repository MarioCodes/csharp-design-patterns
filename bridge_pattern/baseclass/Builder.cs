namespace builderPattern.baseclass
{
    public interface Builder
    {
        public void Reset();
        public void SetSeats(int seats);
        public void SetEngine(string engine);
        public void SetTripComputer(bool tripComputer);
        public void SetGps(bool gps);
    }
}