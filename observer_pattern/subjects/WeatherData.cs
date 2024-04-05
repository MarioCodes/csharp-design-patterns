using observerPattern.observers.@interface;
using observerPattern.subjects.@interface;
using System.Collections.Generic;

namespace observerPattern.Services
{
    // this is the class that holds the state and the one that may change. We want to update all Observers when this class changes
    public class WeatherData : Subject
    {
        // this holds all observers when they register themselves
        private List<Observer> observers;
        private float temperature;
        private float humidity;
        private float pressure;

        public WeatherData()
        {
            observers = new List<Observer>();
        }

        public void RegisterObserver(Observer o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(Observer o)
        {
            // TODO: check what happens if o is not present inside the list 
            observers.Remove(o);
        }

        public void NotifyObservers()
        {
            observers.ForEach(observer => observer.Update(temperature, humidity, pressure));
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            MeasurementsChanged();
        }
    }
}
