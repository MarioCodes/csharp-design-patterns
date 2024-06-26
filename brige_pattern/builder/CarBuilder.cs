using builderPattern.entity;
using builderPattern.interfaces;

namespace builderPattern.builder
{
    public class CarBuilder : Builder
    {
        private Car _car;

        public CarBuilder()
        {
            _car = new Car();
        }

        public void Reset()
        {
            _car = new Car();
        }

        /*
         * Concrete builders are supposed to provide their own methods to retrieve the results.
         *  That's because various types of builders may create various types of products that don't all follow the same interface.
         */
        public Car GetProduct()
        {
            Car builtCar = _car;
            Reset();
            return builtCar;
        }

        public void SetEngine(string engine)
        {
            _car.Engine = engine;
        }

        public void SetGps(bool gps)
        {
            _car.Gps = gps;
        }

        public void SetSeats(int seats)
        {
            _car.Seats = seats;
        }

        public void SetTripComputer(bool tripComputer)
        {
            _car.TripComputer = tripComputer;
        }

    }
}
