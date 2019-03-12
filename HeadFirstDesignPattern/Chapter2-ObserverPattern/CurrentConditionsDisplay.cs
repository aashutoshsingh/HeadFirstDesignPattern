using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.Chapter2_ObserverPattern
{
    class CurrentConditionsDisplay : IObserver, IDisplay
    {
        private float Temperature;
        private float Humidity;
        private ISubject WeatherData;

        public CurrentConditionsDisplay(WeatherData weatherData)
        {
            WeatherData = weatherData;
            WeatherData.RegisterObserver(this);
        }
        public void Display()
        {
            Console.WriteLine($"Temperature : {Temperature} C, Humidity : {Humidity} % humidity");
        }

        public void Update(float temp, float humidity, float pressure)
        {
            Temperature = temp;
            Humidity = humidity;
            Display();
        }
    }
}
