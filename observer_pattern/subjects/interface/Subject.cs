using observerPattern.observers.@interface;

namespace observerPattern.subjects.@interface
{
    public interface Subject
    {
        // both of these methods take an Observer as an argument. This is the observer to be registered or removed
        public void RegisterObserver(Observer o);
        public void RemoveObserver(Observer o);
        // this is called to notify all observers when the subject's state has changed
        public void NotifyObservers();

    }
}
