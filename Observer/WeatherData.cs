using System;
using System.Collections.Generic;

namespace Observer
{
    public class WeatherData : IObserverable
    {
        private float Temperature { get; set; }
        private float Humidity { get; set; }
        private float Pressure { get; set; }
        private List<IObserver> observers;

        public WeatherData()
        {
            observers = new List<IObserver>();
        }

        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void DeleteObserver(IObserver observer)
        {
            int i = observers.IndexOf(observer);
            if (i > 0)
                observers.RemoveAt(i);
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(Temperature, Humidity, Pressure);
            }
        }

        public void MeasurementsChanged(){
            NotifyObservers();
        }

        public void SetMeasurementChanged(float temperature,float humidity,float pressure){
            this.Temperature = temperature;
            this.Humidity = humidity;
            this.Pressure = pressure;
            MeasurementsChanged();
        }
    }
}
