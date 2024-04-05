namespace observerPattern.observers.@interface
{
    public interface Observer
    {
        // these are the state values all Observers get from the Subject when there's a change
        public void Update(float temp, float humidity, float pressure);
    }
}
