using System;
namespace Observer
{
    public interface IObserverable
    {
        void AddObserver(IObserver observer);
        void DeleteObserver(IObserver observer);
        void NotifyObservers();
    }
}
