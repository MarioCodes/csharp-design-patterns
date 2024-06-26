using builderPattern.entity;
using builderPattern.interfaces;

namespace builderPattern.builder
{
    public class CarManualBuilder : Builder
    {
        private Manual _manual;

        public CarManualBuilder()
        {
            _manual = new Manual();
        }

        public void Reset()
        {
            _manual = new Manual();
        }

        /*
         * Concrete builders are supposed to provide their own methods to retrieve the results.
         *  That's because various types of builders may create various types of products that don't all follow the same interface.
         */
        public Manual GetProduct()
        {
            Manual builtManual = _manual;
            Reset();
            return builtManual;
        }

        public void SetEngine(string engine)
        {
            // document engines into manual
        }
        
        public void SetGps(bool gps)
        {
            // document gps into manual
        }

        public void SetSeats(int seats)
        {
            // document seats into manual
        }

        public void SetTripComputer(bool tripComputer)
        {
            // document trip computer into manual
        }
    }
}
