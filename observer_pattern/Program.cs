using observerPattern.observers;
using observerPattern.observers.@interface;
using observerPattern.Services;

namespace template
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();
            DisplayElement currentDisplay = new CurrentConditionsDisplay(weatherData);
            DisplayElement futureDisplay = new FutureConditionsDisplay(weatherData);

            weatherData.SetMeasurements(80, 65, 30.4f);
            weatherData.SetMeasurements(40, 25, 28.4f);
        }

    }
}
