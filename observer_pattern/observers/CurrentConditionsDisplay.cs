using observerPattern.observers.@interface;
using observerPattern.subjects.@interface;
using System;

namespace observerPattern.observers
{
    // this is an Observer. The method Update will be called when the state from WeatherData changes
    public class CurrentConditionsDisplay : Observer, DisplayElement
    {
        private float temperature;
        private float humidity;

        // we save this here in case we may want to remove the observer
        private Subject weatherData;

        public CurrentConditionsDisplay(Subject weatherData)
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
            Console.WriteLine($"current conditions display: temp {this.temperature}º, humidity {this.humidity}%");
        }
    }
}
