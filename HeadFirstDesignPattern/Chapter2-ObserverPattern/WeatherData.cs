using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.Chapter2_ObserverPattern
{
    class WeatherData : ISubject
    {
        private List<IObserver> Observers;
        private float Temperature;
        private float Humidity;
        private float Pressure;

        public WeatherData()
        {
            Observers = new List<IObserver>();
        }
        public void NotifyObserver()
        {
            Observers.ForEach(o => o.Update(Temperature, Humidity, Pressure));
        }

        public void RegisterObserver(IObserver o)
        {
            Observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            if (Observers.Contains(o))
                Observers.Remove(o);
        }

        public void MeasurementChanged()
        {
            NotifyObserver();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            Temperature = temperature;
            Humidity = humidity;
            Pressure = pressure;
            MeasurementChanged();
        }
    }
}
