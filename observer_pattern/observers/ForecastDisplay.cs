using observerPattern.observers.@interface;
using observerPattern.subjects.@interface;
using System;

namespace observerPattern.observers
{
    // this implements Observer so it can get changes from WeatherData
    public class ForecastDisplay : Observer, DisplayElement
    {
        private float temperature;
        private float humidity;
        private Subject weatherData;

        public ForecastDisplay(Subject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(float temp, float humidity, float pressure)
        {
            temperature = temp;
            this.humidity = humidity;
            Display();
        }

        public void Display()
        {
            Console.WriteLine($"forecast display based on the barometer: temp {this.temperature}º, humidity {this.humidity}%");
        }
    }
}
