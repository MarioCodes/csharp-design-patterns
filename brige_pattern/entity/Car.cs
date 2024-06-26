namespace builderPattern.entity
{
    public class Car
    {
        public int Seats { get; set; }
        public string Engine { get; set; }
        public bool TripComputer { get; set; }
        public bool Gps { get; set; }

        public string ToString
        {
            get
            {
                return $"car with {Seats} seats, {Engine} engine. Has tripComputer {TripComputer} and GPS {Gps}";
            }
        }
    }
}
